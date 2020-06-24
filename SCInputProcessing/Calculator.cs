﻿using SCInputProcessing.Displaying;
using SCInputProcessing.InputHandling;
using SCInputProcessing.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing
{
    public class Calculator
    {
        public List<string> inputSequence;

        public InputHandler inputHandler;
        public Processor processor;
        public Display display;

        public List<List<string>> operatorList;
        public List<string> binaryOperators;
        public List<string> preUnaryOperators;
        public List<string> postUnaryOperators;

        public Calculator()
        {
            inputSequence = new List<string> { "" };
            inputHandler = new InputHandler(this);
            processor = new Processor(this);
            display = new Display(this);

            operatorList = new List<List<string>>
            {
                new List<string>{"!", "ln", "log", "^", "sqrt"},
                new List<string>{"x", "/", "%"},
                new List<string>{"+", "-"}
            };
            binaryOperators = new List<string> { "^", "x", "/", "%", "+", "-" };
            preUnaryOperators = new List<string> { "ln", "log", "sqrt" };
            postUnaryOperators = new List<string> { "!" };
        }

        
    }
}
