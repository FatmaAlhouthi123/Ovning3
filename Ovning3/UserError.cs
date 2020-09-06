using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3 {
    abstract class UserError {




        public abstract string UEMessage();

    }


    class NumericInputError : UserError {
        public override string UEMessage() {

            return "You tried to use a numeric inputin a text only field. This fired an error!";
        }
    }


    class TextInputError : UserError {

        public override string UEMessage() {

            return "You tried to use a text input in anumericonly field. This fired an error!";
        }

    }


    class errorClass1 : UserError {

        public override string UEMessage() {

            return "Error 1! wrong inpt!";
        }
    }
    class errorClass2 : UserError {

        public override string UEMessage() {

            return "Error 2! wrong inpt!";

        }

    }
    class errorClass3 : UserError {

        public override string UEMessage() {

            return "Error 3! wrong inpt!";

        }

    }




}


