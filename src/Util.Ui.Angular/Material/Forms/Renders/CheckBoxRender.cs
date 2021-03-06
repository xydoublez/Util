﻿using Util.Ui.Builders;
using Util.Ui.Configs;
using Util.Ui.Material.Enums;
using Util.Ui.Material.Forms.Builders;
using Util.Ui.Renders;

namespace Util.Ui.Material.Forms.Renders {
    /// <summary>
    /// 复选框渲染器
    /// </summary>
    public class CheckBoxRender : RenderBase {
        /// <summary>
        /// 配置
        /// </summary>
        private readonly Config _config;

        /// <summary>
        /// 初始化复选框渲染器
        /// </summary>
        /// <param name="config">配置</param>
        public CheckBoxRender( Config config ) : base( config ) {
            _config = config;
        }

        /// <summary>
        /// 获取标签生成器
        /// </summary>
        protected override TagBuilder GetTagBuilder() {
            var builder = new CheckBoxBuilder();
            Config( builder );
            return builder;
        }

        /// <summary>
        /// 配置
        /// </summary>
        protected void Config( TagBuilder builder ) {
            ConfigId( builder );
            ConfigName( builder );
            ConfigLabel( builder );
            ConfigDisabled( builder );
            ConfigModel( builder );
            ConfigIndeterminate( builder );
            ConfigRequired( builder );
            ConfigEvents( builder );
        }

        /// <summary>
        /// 配置标识
        /// </summary>
        private void ConfigId( TagBuilder builder ) {
            if( _config.Contains( UiConst.Id ) )
                builder.AddAttribute( $"#{_config.GetValue( UiConst.Id )}", "", false );
        }

        /// <summary>
        /// 配置名称
        /// </summary>
        private void ConfigName( TagBuilder builder ) {
            builder.AddAttribute( UiConst.Name, _config.GetValue( UiConst.Name ) );
        }

        /// <summary>
        /// 配置标签
        /// </summary>
        private void ConfigLabel( TagBuilder builder ) {
            builder.SetContent( _config.GetValue( UiConst.Text ) );
            builder.AddAttribute( "labelPosition", _config.GetValue<LabelPosition?>( UiConst.Position )?.Description() );
        }

        /// <summary>
        /// 配置禁用
        /// </summary>
        private void ConfigDisabled( TagBuilder builder ) {
            builder.AddAttribute( "[disabled]", _config.GetBoolValue( UiConst.Disabled ) );
        }

        /// <summary>
        /// 配置模型绑定
        /// </summary>
        private void ConfigModel( TagBuilder builder ) {
            builder.AddAttribute( "[(ngModel)]", _config.GetValue( UiConst.Model ) );
        }

        /// <summary>
        /// 配置不确定样式
        /// </summary>
        private void ConfigIndeterminate( TagBuilder builder ) {
            builder.AddAttribute( "[indeterminate]", _config.GetValue( UiConst.Indeterminate ) );
        }

        /// <summary>
        /// 配置必填项
        /// </summary>
        private void ConfigRequired( TagBuilder builder ) {
            builder.AddAttribute( "[required]", _config.GetBoolValue( UiConst.Required ) );
        }

        /// <summary>
        /// 配置事件
        /// </summary>
        private void ConfigEvents( TagBuilder builder ) {
            builder.AddAttribute( "(change)", _config.GetValue( UiConst.OnChange ) );
        }
    }
}
