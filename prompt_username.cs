namespace prompt_user
{//opening of namespace
    public class prompt_username
    {//opening of class
    //global variable declaration
    
        private string username = string.Empty;


        //void method to prompt user 
        //to craete a method we start by using an access modifer and then follows nby the type of method and after that the name of the methid follow and put () aD {}
        public void collect_username()
        {//start of colect_username 



        }// end of collect_username method
        //boolean method to check if username is entered or not 
        private Boolean check_username ()
        {//start of check_username
            //if statement check if user has entered their  name or not

            if(username != "" )//empty quotation is = to user ha  not entered naything 
            
            {//start of if
                //return true and the message 
                Console.WriteLine("Chatbot : Hey" + username + ", ho wcan i help you ?");//then return
                return true;

                }//end of if
            else
            {//start of else
             //error message 
                Console.WriteLine("Chatbot: Please enter your name ");
                return false;
            }//end of else

        }//end of  username 
    }//end of class
}//end of namespace