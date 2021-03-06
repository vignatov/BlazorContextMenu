﻿using BlazorContextMenu.Components;
using Microsoft.AspNetCore.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorContextMenu
{
    public class MenuItemClickEventArgs
    {
        public MenuItemClickEventArgs(UIMouseEventArgs mouseEvent,string contextMenuId, string contextMenuTargetId, ElementRef menuItemElement, Item menuItem)
        {
            MouseEvent = mouseEvent;
            ContextMenuId = contextMenuId;
            ContextMenuTargetId = contextMenuTargetId;
            MenuItemElement = menuItemElement;
            MenuItem = menuItem;
        }

        public UIMouseEventArgs MouseEvent { get; protected set; }
        public bool IsCanceled { get; set; }
        public string ContextMenuId { get; protected set; }
        public string ContextMenuTargetId { get; protected set; }
        public ElementRef MenuItemElement { get; protected set; }
        public Item MenuItem { get; protected set; }
    }
}
