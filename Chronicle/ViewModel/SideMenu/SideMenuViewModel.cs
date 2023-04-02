using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronicle
{
    /// <summary>
    /// View model for the <see cref="SideMenuControl"/>
    /// </summary>
    public class SideMenuViewModel : BaseViewModel
    {
        public string MenuTitle { get; set; }

        public IconType MenuIcon { get; set; }

        public bool HasSubMenu { get; set; }

        



        /// <summary>
        /// The list of submenu of this menu
        /// </summary>
        public ObservableCollection<SubMenuDesignModel> SubMenu { get; set; } = new ObservableCollection<SubMenuDesignModel>();

        public bool IsSelected { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// 
        public SideMenuViewModel()
        {

        }

        public SideMenuViewModel(string menuTitle, IconType menuIcon, bool hasSubMenu, ObservableCollection<SubMenuDesignModel> subMenu)
        {
            // Set default properties
            if (hasSubMenu && subMenu.Count > 0)
            {
                SubMenu= subMenu;
            }

            MenuTitle = menuTitle;
            MenuIcon = menuIcon;
            HasSubMenu = hasSubMenu;
            
            IsSelected ^= false;
            OnPropertyChanged(nameof(IsSelected));
        }
    }
}
