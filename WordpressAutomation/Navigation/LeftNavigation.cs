using System;


namespace WordpressAutomation
{
    public class LeftNavigation
    {
       

        public class Posts
        {
            public class AddNew
            {
                public static void Select()
                {
                    MenuSelector.Select("#header > div.masterbar__publish > a > span");
                    
                }
            }
        }

        public class Pages
        {
            public class AllPages
            {
                public static void Select()
                {
                    MenuSelector.Select("");
                }
            }

        }
    }
}
