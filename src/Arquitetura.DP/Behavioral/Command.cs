using System;
using System.Collections.Generic;

namespace Arquitetura.DP.Behavioral
{
    internal abstract class Commander
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }

    internal class CalculatorCommand : Commander
    {
        private char _operator;
        private int _operand;
        private readonly Calculator _calculator;

        public CalculatorCommand(Calculator calculator,
            char @operator, int operand)
        {
            _calculator = calculator;
            _operator = @operator;
            _operand = operand;
        }

        public char Operator
        {
            set { _operator = value; }
        }

        public int Operand
        {
            set { _operand = value; }
        }

        public override void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        public override void UnExecute()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        private static char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("@operator");
            }
        }
    }

    internal class Calculator
    {
        private int _curr;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': _curr += operand; break;
                case '-': _curr -= operand; break;
                case '*': _curr *= operand; break;
                case '/': _curr /= operand; break;
            }
            Console.WriteLine(
              "Valor atual = {0,3} (dado {1} {2})",
              _curr, @operator, operand);
        }
    }

    public class User
    {
        // Initializers
        private readonly Calculator _calculator = new Calculator();
        private readonly List<Commander> _commands = new List<Commander>();
        private int _current;

        public void Compute(char @operator, int operand)
        {
            // Create command operation and execute it
            Commander command = new CalculatorCommand(
              _calculator, @operator, operand);
            command.Execute();

            // Add command to undo list
            _commands.Add(command);
            _current++;
        }

        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Retornando {0} níveis ", levels);
            // Perform redo operations
            for (var i = 0; i < levels; i++)
            {
                if (_current >= _commands.Count - 1) continue;
                var command = _commands[_current++];
                command.Execute();
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Desfazendo {0} níveis ", levels);
            // Perform undo operations
            for (var i = 0; i < levels; i++)
            {
                if (_current <= 0) continue;
                var command = _commands[--_current];
                command.UnExecute();
            }
        }
    }

    public class Command
    {
        public static void Execucao()
        {
            var user = new User();

            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            user.Undo(4);

            user.Redo(3);
        }
    }
}