//
// Bubble.cs: Provides both a UITableViewCell that can be used with UITableViews
// as well as a ChatBubble which is a MonoTouch.Dialog Element that can be used
// inside a DialogViewController for quick UIs.
//
// Author:
//   Miguel de Icaza
//

using System;
using Foundation;
using MonoTouch.Dialog;
using UIKit;
using Element = Xamarin.Forms.Element;

namespace Crosschat.Client.iOS.CustomRenderers
{
    
    public class ChatBubble : Element, IElementSizing
    {
        bool isLeft;

        private string _text;

        public ChatBubble(bool isLeft, string text)
            : base()
        {
            _text = text;
            this.isLeft = isLeft;
        }

        public UITableViewCell GetCell(UITableView tv)
        {
            var cell = tv.DequeueReusableCell(isLeft ? BubbleCell.KeyLeft : BubbleCell.KeyRight) as BubbleCell;
            if (cell == null)
                cell = new BubbleCell(isLeft);
            cell.Update(_text);
            return cell;
        }

        public nfloat GetHeight(UITableView tableView, NSIndexPath indexPath)
        {
            return BubbleCell.GetSizeForText(tableView, _text).Height + BubbleCell.BubblePadding.Height;
        }
    }
    
}
