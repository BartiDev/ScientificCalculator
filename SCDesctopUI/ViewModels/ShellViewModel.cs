﻿using Caliburn.Micro;
using SCInputProcessing;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCDesctopUI.ViewModels
{
    public class ShellViewModel : Screen
    {
		private string _calculatorDisplay;
		private Calculator calculator = new Calculator();

		public string CalculatorDisplay
		{
			get { return _calculatorDisplay; }
			set { _calculatorDisplay = value; NotifyOfPropertyChange(() => CalculatorDisplay); }
		}

		public bool CanMakeNumericInput 
		{ 
			get { return calculator.inputHandler.CanHandleNumericInput(); }
		}
		public void MakeNumericInput(string text)
		{
			calculator.inputHandler.HandleNumericInput(text);

			CalculatorDisplay = calculator.display.SendDisplay();
			UpdateProperties();
		}


		public bool CanMakeDotInput
		{
			get { return calculator.inputHandler.CanHandleDotInput(); }
		}
		public void MakeDotInput(string text)
		{
			calculator.inputHandler.HandleDotInput();

			CalculatorDisplay = calculator.display.SendDisplay();
			UpdateProperties();
		}


		public bool CanMakeBinaryOperatorInput
		{
			get { return calculator.inputHandler.CanHandleBinaryOperatorInput(); }	
		}
		public void MakeBinaryOperatorInput(string text)
		{
			calculator.inputHandler.HandleBinaryOperatorInput(text);

			CalculatorDisplay = calculator.display.SendDisplay();
			UpdateProperties();
		}


		public bool CanMakeMinusInput
		{
			get { return calculator.inputHandler.CanHandleMinusInput(); }
		}
		public void MakeMinusInput(string text)
		{
			calculator.inputHandler.HandleMinusInput();

			CalculatorDisplay = calculator.display.SendDisplay();
			UpdateProperties();
		}


		public bool CanMakePreUnaryOperatorInput
		{
			get { return calculator.inputHandler.CanHandlePreUnaryOperatorInput(); }
		}
		public void MakePreUnaryOperatorInput(string text)
		{
			calculator.inputHandler.HandlePreUnaryOperatorInput(text);

			CalculatorDisplay = calculator.display.SendDisplay();
			UpdateProperties();
		}


		public bool CanMakePostUnaryOperatorInput
		{
			get { return calculator.inputHandler.CanHandlePostUnaryOperatorInput(); }
		}
		public void MakePostUnaryOperatorInput(string text)
		{
			calculator.inputHandler.HandlePostUnaryOperatorInput(text);

			CalculatorDisplay = calculator.display.SendDisplay();
			UpdateProperties();
		}


		public bool CanMakeLParanthesisInput
		{
			get { return calculator.inputHandler.CanHandleLParanthesisInput(); }
		}
		public void MakeLParanthesisInput(string text)
		{
			calculator.inputHandler.HandleLParanthesisInput();

			CalculatorDisplay = calculator.display.SendDisplay();
			UpdateProperties();
		}


		public bool CanMakeRParanthesisInput
		{
			get { return calculator.inputHandler.CanHandleRParanthesisInput(); }
		}
		public void MakeRParanthesisInput(string text)
		{
			calculator.inputHandler.HandleRParanthesisInput();

			CalculatorDisplay = calculator.display.SendDisplay();
			UpdateProperties();
		}


		public bool CanMakeEqualInput
		{
			get
			{
				if (string.IsNullOrWhiteSpace(CalculatorDisplay))
					return true;
				return true;
			}
		}
		public void MakeEqualInput(string text)
		{
			CalculatorDisplay += text;
			NotifyOfPropertyChange(() => CanMakeEqualInput);
		}


		

		public bool CanMakeEraseInput
		{
			get
			{
				if (string.IsNullOrWhiteSpace(CalculatorDisplay))
					return true;
				return true;
			}
		}

		public void MakeEraseInput(string text)
		{
			CalculatorDisplay += text;
			NotifyOfPropertyChange(() => CanMakeEraseInput);
		}
		private void UpdateProperties()
		{
			NotifyOfPropertyChange(() => CanMakeBinaryOperatorInput);
			NotifyOfPropertyChange(() => CanMakeDotInput);
			NotifyOfPropertyChange(() => CanMakeNumericInput);
			NotifyOfPropertyChange(() => CanMakeMinusInput);
			NotifyOfPropertyChange(() => CanMakePreUnaryOperatorInput);
			NotifyOfPropertyChange(() => CanMakePostUnaryOperatorInput);
			NotifyOfPropertyChange(() => CanMakeLParanthesisInput);
			NotifyOfPropertyChange(() => CanMakeRParanthesisInput);
		}
	}
}
