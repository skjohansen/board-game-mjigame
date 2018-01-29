﻿using System.Web.Optimization;

namespace TicTacToe
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles
                .Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js"));

            bundles
                .Add(new ScriptBundle("~/bundles/jquery-signalr")
                .Include("~/Scripts/jquery.signalR-{version}.js"));

            bundles
                .Add(new StyleBundle("~/Content/css")
                .Include("~/Content/Site.css"));
        }
    }
}
