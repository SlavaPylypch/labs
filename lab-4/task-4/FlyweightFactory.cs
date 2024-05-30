using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    public class FlyweightFactory
    {
        private readonly Dictionary<string, LightElementNode> _elements = new Dictionary<string, LightElementNode>();

        public LightElementNode GetElement(string tagName, bool isBlock, bool isSelfClosing)
        {
            string key = $"{tagName}_{isBlock}_{isSelfClosing}";

            if (!_elements.ContainsKey(key))
            {
                _elements[key] = new LightElementNode(tagName, isBlock, isSelfClosing);
            }

            // Повертаємо копію об'єкта, щоб уникнути модифікації існуючих об'єктів
            LightElementNode element = _elements[key];
            return new LightElementNode(element.TagName, element.IsBlock, element.IsSelfClosing)
            {
                CssClasses = new List<string>(element.CssClasses),
                Children = new List<LightNode>(element.Children)
            };
        }
    }
}
