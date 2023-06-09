﻿using System.Text;

namespace Smartstore.WebApi.Client
{
    internal static class ComboBoxExtensions
    {
        private const char _delimiter = '¶';

        public static void InsertRolled(this ComboBox combo, string str, int max)
        {
            if (!string.IsNullOrEmpty(str))
            {
                int i;
                for (i = combo.Items.Count - 1; i >= 0; --i)
                {
                    if (string.Compare(combo.Items[i].ToString(), str, true) == 0)
                        combo.Items.RemoveAt(i);
                }

                combo.Items.Insert(0, str);

                for (i = combo.Items.Count - 1; i > max; --i)
                {
                    combo.Items.RemoveAt(i);
                }

                combo.Text = str;
            }
        }

        public static void FromString(this ComboBox.ObjectCollection coll, string values)
        {
            if (!string.IsNullOrWhiteSpace(values))
            {
                string[] items = values.Split(new[] { _delimiter }, StringSplitOptions.RemoveEmptyEntries);
                coll.AddRange(items);
            }
        }

        public static string IntoString(this ComboBox.ObjectCollection coll)
        {
            if (coll.Count <= 0)
                return string.Empty;

            var sb = new StringBuilder();
            foreach (var item in coll)
            {
                if (sb.Length > 0)
                    sb.Append(_delimiter);
                sb.Append(item);
            }

            return string.Join(_delimiter.ToString(), sb.ToString());
        }

        public static void RemoveCurrent(this ComboBox combo)
        {
            combo.Items.Remove(combo.Text);
            combo.ResetText();
        }
    }
}
