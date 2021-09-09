using System;

namespace CititorServer.Data.Model
{
    public class MenuInfo
    {
        public int MenuId {get;set;}
        public int ParentMenuId {get;set;}
        public string PageName {get;set;}
        public string MenuName {get;set;}
        public string  IconName {get;set;}
    }
}
