﻿using System.Collections.Generic;
using Util.Ui.Configs;
using Util.Ui.TagHelpers;

namespace Util.Ui.Material.Forms.Configs {
    /// <summary>
    /// 下拉列表配置
    /// </summary>
    public class SelectConfig : Config {
        /// <summary>
        /// 列表项集合
        /// </summary>
        public readonly List<Item> Items = new List<Item>();

        /// <summary>
        /// 初始化下拉列表配置
        /// </summary>
        public SelectConfig() {
        }

        /// <summary>
        /// 初始化下拉列表配置
        /// </summary>
        /// <param name="context">TagHelper上下文</param>
        public SelectConfig( Context context ) : base( context ) {
        }

        /// <summary>
        /// 添加项集合
        /// </summary>
        /// <param name="items">列表项集合</param>
        public void AddItems( params Item[] items ) {
            Items.AddRange( items );
        }

        /// <summary>
        /// 获取验证消息
        /// </summary>
        public override string GetValidateMessage() {
            if ( !Contains( UiConst.Url ) && !Contains( UiConst.DataSource ) )
                return "请设置数据源或Url";
            return string.Empty;
        }
    }
}
