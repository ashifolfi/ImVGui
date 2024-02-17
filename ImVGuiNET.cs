/*
    ImVGuiNET

    A collection of Vgui styled controls for ImGui

    (C) 2024 K. "eden/ashi" J.
*/
using System;
using ImGuiNET;
#if UNITY_2019_4_OR_NEWER
    using UnityEngine;
#else
    using System.Numerics;
#endif

namespace ImVGuiNET {
    public static class ImVGui {
        public static bool buttonUseSelectionColor = false;

    #region Style Colors
        public static void StyleEngineTools() {
            var style = ImGui.GetStyle();

            style.WindowPadding = new Vector2(20, 6);
            style.WindowTitleAlign = new Vector2(0.30f, 0.50f);
            style.ScrollbarSize = 17;
            style.FramePadding = new Vector2(5, 6);

            style.FrameRounding = 0;
            style.WindowRounding = 0;
            style.ScrollbarRounding = 0;
            style.ChildRounding = 0;
            style.PopupRounding = 0;
            style.GrabRounding = 0;
            style.TabRounding = 0;

            style.WindowBorderSize = 1;
            style.FrameBorderSize = 1;
            style.ChildBorderSize = 1;
            style.PopupBorderSize = 1;
            style.TabBorderSize = 1;
            buttonUseSelectionColor = true;

            style.Colors[(int)ImGuiCol.Text]                   = new Vector4(1.00f, 1.00f, 1.00f, 1.00f);
            style.Colors[(int)ImGuiCol.TextDisabled]           = new Vector4(0.50f, 0.50f, 0.50f, 1.00f);
            style.Colors[(int)ImGuiCol.WindowBg]               = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            style.Colors[(int)ImGuiCol.ChildBg]                = new Vector4(0.00f, 0.00f, 0.00f, 0.00f);
            style.Colors[(int)ImGuiCol.PopupBg]                = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            style.Colors[(int)ImGuiCol.Border]                 = new Vector4(0.71f, 0.71f, 0.71f, 1.00f);
            style.Colors[(int)ImGuiCol.BorderShadow]           = new Vector4(0.00f, 0.00f, 0.00f, 1.00f);
            style.Colors[(int)ImGuiCol.FrameBg]                = new Vector4(0.17f, 0.17f, 0.17f, 1.00f);
            style.Colors[(int)ImGuiCol.FrameBgHovered]         = new Vector4(0.17f, 0.17f, 0.17f, 1.00f);
            style.Colors[(int)ImGuiCol.FrameBgActive]          = new Vector4(0.17f, 0.17f, 0.17f, 1.00f);
            style.Colors[(int)ImGuiCol.TitleBg]                = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            style.Colors[(int)ImGuiCol.TitleBgActive]          = new Vector4(0.34f, 0.34f, 0.34f, 1.00f);
            style.Colors[(int)ImGuiCol.TitleBgCollapsed]       = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            style.Colors[(int)ImGuiCol.MenuBarBg]              = new Vector4(0.20f, 0.20f, 0.20f, 1.00f);
            style.Colors[(int)ImGuiCol.ScrollbarBg]            = new Vector4(0.02f, 0.02f, 0.02f, 0.52f);
            style.Colors[(int)ImGuiCol.ScrollbarGrab]          = new Vector4(0.31f, 0.31f, 0.31f, 1.00f);
            style.Colors[(int)ImGuiCol.ScrollbarGrabHovered]   = new Vector4(0.41f, 0.41f, 0.41f, 1.00f);
            style.Colors[(int)ImGuiCol.ScrollbarGrabActive]    = new Vector4(0.51f, 0.51f, 0.51f, 1.00f);
            style.Colors[(int)ImGuiCol.CheckMark]              = new Vector4(1.00f, 1.00f, 1.00f, 1.00f);
            style.Colors[(int)ImGuiCol.SliderGrab]             = new Vector4(1.00f, 0.49f, 0.11f, 0.54f);
            style.Colors[(int)ImGuiCol.SliderGrabActive]       = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            style.Colors[(int)ImGuiCol.Button]                 = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            style.Colors[(int)ImGuiCol.ButtonHovered]          = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            style.Colors[(int)ImGuiCol.ButtonActive]           = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            style.Colors[(int)ImGuiCol.Header]                 = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            style.Colors[(int)ImGuiCol.HeaderHovered]          = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            style.Colors[(int)ImGuiCol.HeaderActive]           = new Vector4(1.00f, 0.49f, 0.11f, 1.00f);
            style.Colors[(int)ImGuiCol.Separator]              = new Vector4(0.43f, 0.43f, 0.50f, 0.41f);
            style.Colors[(int)ImGuiCol.SeparatorHovered]       = new Vector4(1.00f, 0.49f, 0.11f, 0.34f);
            style.Colors[(int)ImGuiCol.SeparatorActive]        = new Vector4(1.00f, 0.49f, 0.11f, 1.00f);
            style.Colors[(int)ImGuiCol.ResizeGrip]             = new Vector4(1.00f, 1.00f, 1.00f, 1.00f);
            style.Colors[(int)ImGuiCol.ResizeGripHovered]      = new Vector4(1.00f, 1.00f, 1.00f, 1.00f);
            style.Colors[(int)ImGuiCol.ResizeGripActive]       = new Vector4(1.00f, 1.00f, 1.00f, 1.00f);
            style.Colors[(int)ImGuiCol.Tab]                    = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            style.Colors[(int)ImGuiCol.TabHovered]             = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            style.Colors[(int)ImGuiCol.TabActive]              = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            style.Colors[(int)ImGuiCol.TabUnfocused]           = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            style.Colors[(int)ImGuiCol.TabUnfocusedActive]     = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            style.Colors[(int)ImGuiCol.DockingPreview]         = new Vector4(0.61f, 0.61f, 0.61f, 1.00f);
            style.Colors[(int)ImGuiCol.DockingEmptyBg]         = new Vector4(1.00f, 0.43f, 0.35f, 1.00f);
            style.Colors[(int)ImGuiCol.PlotLines]              = new Vector4(0.90f, 0.70f, 0.00f, 1.00f);
            style.Colors[(int)ImGuiCol.PlotLinesHovered]       = new Vector4(1.00f, 0.60f, 0.00f, 1.00f);
            style.Colors[(int)ImGuiCol.PlotHistogram]          = new Vector4(0.26f, 0.59f, 0.98f, 0.34f);
            style.Colors[(int)ImGuiCol.PlotHistogramHovered]   = new Vector4(1.00f, 1.00f, 0.00f, 0.78f);
            style.Colors[(int)ImGuiCol.TableHeaderBg]          = new Vector4(0.26f, 0.59f, 0.98f, 1.00f);
            style.Colors[(int)ImGuiCol.TableBorderStrong]      = new Vector4(1.00f, 1.00f, 1.00f, 0.67f);
            style.Colors[(int)ImGuiCol.TableBorderLight]       = new Vector4(0.80f, 0.80f, 0.80f, 0.31f);
            style.Colors[(int)ImGuiCol.TableRowBg]             = new Vector4(0.80f, 0.80f, 0.80f, 0.38f);
            style.Colors[(int)ImGuiCol.TableRowBgAlt]          = new Vector4(0.80f, 0.80f, 0.80f, 1.00f);
            style.Colors[(int)ImGuiCol.TextSelectedBg]         = new Vector4(1.00f, 0.49f, 0.11f, 1.00f);
            style.Colors[(int)ImGuiCol.DragDropTarget]         = new Vector4(1.00f, 0.49f, 0.11f, 1.00f);
            style.Colors[(int)ImGuiCol.NavHighlight]           = new Vector4(1.00f, 0.00f, 0.94f, 1.00f);
            style.Colors[(int)ImGuiCol.NavWindowingHighlight]  = new Vector4(1.00f, 0.00f, 0.69f, 1.00f);
            style.Colors[(int)ImGuiCol.NavWindowingDimBg]      = new Vector4(0.12f, 0.00f, 1.00f, 1.00f);
            style.Colors[(int)ImGuiCol.ModalWindowDimBg]       = new Vector4(0.00f, 0.00f, 1.00f, 1.00f);
        }

        public static void StyleSteamGreen() {
            var style = ImGui.GetStyle();

            style.WindowPadding = new Vector2(20, 6);
            style.WindowTitleAlign = new Vector2(0.30f, 0.50f);
            style.ScrollbarSize = 17;
            style.FramePadding = new Vector2(5, 6);

            style.FrameRounding = 0;
            style.WindowRounding = 0;
            style.ScrollbarRounding = 0;
            style.ChildRounding = 0;
            style.PopupRounding = 0;
            style.GrabRounding = 0;
            style.TabRounding = 0;

            style.WindowBorderSize = 1;
            style.FrameBorderSize = 1;
            style.ChildBorderSize = 1;
            style.PopupBorderSize = 1;
            style.TabBorderSize = 1;
            buttonUseSelectionColor = false;

            style.Colors[(int)ImGuiCol.Text]                   = new Vector4(0.85f, 0.87f, 0.83f, 1.00f);
            style.Colors[(int)ImGuiCol.TextDisabled]           = new Vector4(0.63f, 0.67f, 0.58f, 1.00f);
            style.Colors[(int)ImGuiCol.WindowBg]               = new Vector4(0.30f, 0.35f, 0.27f, 1.00f);
            style.Colors[(int)ImGuiCol.ChildBg]                = new Vector4(0.00f, 0.00f, 0.00f, 0.00f);
            style.Colors[(int)ImGuiCol.PopupBg]                = new Vector4(0.30f, 0.35f, 0.27f, 1.00f);
            style.Colors[(int)ImGuiCol.Border]                 = new Vector4(0.53f, 0.57f, 0.50f, 1.00f);
            style.Colors[(int)ImGuiCol.BorderShadow]           = new Vector4(0.16f, 0.18f, 0.13f, 1.00f);
            style.Colors[(int)ImGuiCol.FrameBg]                = new Vector4(0.24f, 0.27f, 0.22f, 1.00f);
            style.Colors[(int)ImGuiCol.FrameBgHovered]         = new Vector4(0.24f, 0.27f, 0.22f, 1.00f);
            style.Colors[(int)ImGuiCol.FrameBgActive]          = new Vector4(0.24f, 0.27f, 0.22f, 1.00f);
            style.Colors[(int)ImGuiCol.TitleBg]                = new Vector4(0.30f, 0.35f, 0.27f, 1.00f);
            style.Colors[(int)ImGuiCol.TitleBgActive]          = new Vector4(0.30f, 0.35f, 0.27f, 1.00f);
            style.Colors[(int)ImGuiCol.TitleBgCollapsed]       = new Vector4(0.30f, 0.35f, 0.27f, 1.00f);
            style.Colors[(int)ImGuiCol.MenuBarBg]              = new Vector4(0.30f, 0.35f, 0.27f, 1.00f);
            style.Colors[(int)ImGuiCol.ScrollbarBg]            = new Vector4(0.35f, 0.42f, 0.31f, 0.52f);
            style.Colors[(int)ImGuiCol.ScrollbarGrab]          = new Vector4(0.30f, 0.35f, 0.27f, 1.00f);
            style.Colors[(int)ImGuiCol.ScrollbarGrabHovered]   = new Vector4(0.30f, 0.35f, 0.27f, 1.00f);
            style.Colors[(int)ImGuiCol.ScrollbarGrabActive]    = new Vector4(0.30f, 0.35f, 0.27f, 1.00f);
            style.Colors[(int)ImGuiCol.CheckMark]              = new Vector4(1.00f, 1.00f, 1.00f, 1.00f);
            style.Colors[(int)ImGuiCol.SliderGrab]             = new Vector4(0.30f, 0.35f, 0.27f, 1.00f);
            style.Colors[(int)ImGuiCol.SliderGrabActive]       = new Vector4(0.30f, 0.35f, 0.27f, 1.00f);
            style.Colors[(int)ImGuiCol.Button]                 = new Vector4(0.30f, 0.35f, 0.27f, 1.00f);
            style.Colors[(int)ImGuiCol.ButtonHovered]          = new Vector4(0.30f, 0.35f, 0.27f, 1.00f);
            style.Colors[(int)ImGuiCol.ButtonActive]           = new Vector4(0.30f, 0.35f, 0.27f, 1.00f);
            style.Colors[(int)ImGuiCol.Header]                 = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            style.Colors[(int)ImGuiCol.HeaderHovered]          = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            style.Colors[(int)ImGuiCol.HeaderActive]           = new Vector4(1.00f, 0.49f, 0.11f, 1.00f);
            style.Colors[(int)ImGuiCol.Separator]              = new Vector4(0.16f, 0.18f, 0.13f, 1.00f);
            style.Colors[(int)ImGuiCol.SeparatorHovered]       = new Vector4(0.16f, 0.18f, 0.13f, 1.00f);
            style.Colors[(int)ImGuiCol.SeparatorActive]        = new Vector4(0.16f, 0.18f, 0.13f, 1.00f);
            style.Colors[(int)ImGuiCol.ResizeGrip]             = new Vector4(1.00f, 1.00f, 1.00f, 1.00f);
            style.Colors[(int)ImGuiCol.ResizeGripHovered]      = new Vector4(1.00f, 1.00f, 1.00f, 1.00f);
            style.Colors[(int)ImGuiCol.ResizeGripActive]       = new Vector4(1.00f, 1.00f, 1.00f, 1.00f);
            style.Colors[(int)ImGuiCol.Tab]                    = new Vector4(0.30f, 0.35f, 0.27f, 1.00f);
            style.Colors[(int)ImGuiCol.TabHovered]             = new Vector4(0.30f, 0.35f, 0.27f, 1.00f);
            style.Colors[(int)ImGuiCol.TabActive]              = new Vector4(0.30f, 0.35f, 0.27f, 1.00f);
            style.Colors[(int)ImGuiCol.TabUnfocused]           = new Vector4(0.30f, 0.35f, 0.27f, 1.00f);
            style.Colors[(int)ImGuiCol.TabUnfocusedActive]     = new Vector4(0.30f, 0.35f, 0.27f, 1.00f);
            style.Colors[(int)ImGuiCol.DockingPreview]         = new Vector4(0.61f, 0.61f, 0.61f, 1.00f);
            style.Colors[(int)ImGuiCol.DockingEmptyBg]         = new Vector4(1.00f, 0.43f, 0.35f, 1.00f);
            style.Colors[(int)ImGuiCol.PlotLines]              = new Vector4(0.90f, 0.70f, 0.00f, 1.00f);
            style.Colors[(int)ImGuiCol.PlotLinesHovered]       = new Vector4(1.00f, 0.60f, 0.00f, 1.00f);
            style.Colors[(int)ImGuiCol.PlotHistogram]          = new Vector4(0.26f, 0.59f, 0.98f, 0.34f);
            style.Colors[(int)ImGuiCol.PlotHistogramHovered]   = new Vector4(1.00f, 1.00f, 0.00f, 0.78f);
            style.Colors[(int)ImGuiCol.TableHeaderBg]          = new Vector4(0.26f, 0.59f, 0.98f, 1.00f);
            style.Colors[(int)ImGuiCol.TableBorderStrong]      = new Vector4(1.00f, 1.00f, 1.00f, 0.67f);
            style.Colors[(int)ImGuiCol.TableBorderLight]       = new Vector4(0.80f, 0.80f, 0.80f, 0.31f);
            style.Colors[(int)ImGuiCol.TableRowBg]             = new Vector4(0.80f, 0.80f, 0.80f, 0.38f);
            style.Colors[(int)ImGuiCol.TableRowBgAlt]          = new Vector4(0.80f, 0.80f, 0.80f, 1.00f);
            style.Colors[(int)ImGuiCol.TextSelectedBg]         = new Vector4(0.58f, 0.53f, 0.19f, 1.00f);
            style.Colors[(int)ImGuiCol.DragDropTarget]         = new Vector4(0.58f, 0.53f, 0.19f, 1.00f);
            style.Colors[(int)ImGuiCol.NavHighlight]           = new Vector4(1.00f, 0.00f, 0.94f, 1.00f);
            style.Colors[(int)ImGuiCol.NavWindowingHighlight]  = new Vector4(1.00f, 0.00f, 0.69f, 1.00f);
            style.Colors[(int)ImGuiCol.NavWindowingDimBg]      = new Vector4(0.12f, 0.00f, 1.00f, 1.00f);
            style.Colors[(int)ImGuiCol.ModalWindowDimBg]       = new Vector4(0.00f, 0.00f, 1.00f, 1.00f);
        }

        public static void StyleSourceGray() {
            var style = ImGui.GetStyle();

            style.WindowPadding = new Vector2(20, 6);
            style.WindowTitleAlign = new Vector2(0.16f, 0.50f);
            style.ScrollbarSize = 17;
            style.FramePadding = new Vector2(5, 6);

            style.FrameRounding = 0;
            style.WindowRounding = 15;
            style.ScrollbarRounding = 0;
            style.ChildRounding = 0;
            style.PopupRounding = 0;
            style.GrabRounding = 0;
            style.TabRounding = 0;

            style.WindowBorderSize = 0;
            style.FrameBorderSize = 1;
            style.ChildBorderSize = 1;
            style.PopupBorderSize = 1;
            style.TabBorderSize = 1;
            buttonUseSelectionColor = false;

            style.Colors[(int)ImGuiCol.Text]                   = new Vector4(1.00f, 1.00f, 1.00f, 1.00f);
            style.Colors[(int)ImGuiCol.TextDisabled]           = new Vector4(0.50f, 0.50f, 0.50f, 1.00f);
            style.Colors[(int)ImGuiCol.WindowBg]               = new Vector4(0.63f, 0.63f, 0.63f, 0.50f);
            style.Colors[(int)ImGuiCol.ChildBg]                = new Vector4(0.00f, 0.00f, 0.00f, 0.00f);
            style.Colors[(int)ImGuiCol.PopupBg]                = new Vector4(1.00f, 0.61f, 0.00f, 1.00f);
            style.Colors[(int)ImGuiCol.Border]                 = new Vector4(0.78f, 0.78f, 0.78f, 0.77f);
            style.Colors[(int)ImGuiCol.BorderShadow]           = new Vector4(0.16f, 0.16f, 0.16f, 0.77f);
            style.Colors[(int)ImGuiCol.FrameBg]                = new Vector4(0.00f, 0.00f, 0.00f, 0.50f);
            style.Colors[(int)ImGuiCol.FrameBgHovered]         = new Vector4(0.00f, 0.00f, 0.00f, 0.50f);
            style.Colors[(int)ImGuiCol.FrameBgActive]          = new Vector4(0.00f, 0.00f, 0.00f, 0.50f);
            style.Colors[(int)ImGuiCol.TitleBg]                = new Vector4(0.63f, 0.63f, 0.63f, 0.50f);
            style.Colors[(int)ImGuiCol.TitleBgActive]          = new Vector4(0.63f, 0.63f, 0.63f, 0.50f);
            style.Colors[(int)ImGuiCol.TitleBgCollapsed]       = new Vector4(0.63f, 0.63f, 0.63f, 0.50f);
            style.Colors[(int)ImGuiCol.MenuBarBg]              = new Vector4(0.20f, 0.20f, 0.20f, 1.00f);
            style.Colors[(int)ImGuiCol.ScrollbarBg]            = new Vector4(1.00f, 1.00f, 1.00f, 0.25f);
            style.Colors[(int)ImGuiCol.ScrollbarGrab]          = new Vector4(0.31f, 0.31f, 0.31f, 1.00f);
            style.Colors[(int)ImGuiCol.ScrollbarGrabHovered]   = new Vector4(0.41f, 0.41f, 0.41f, 1.00f);
            style.Colors[(int)ImGuiCol.ScrollbarGrabActive]    = new Vector4(0.51f, 0.51f, 0.51f, 1.00f);
            style.Colors[(int)ImGuiCol.CheckMark]              = new Vector4(1.00f, 1.00f, 1.00f, 1.00f);
            style.Colors[(int)ImGuiCol.SliderGrab]             = new Vector4(0.42f, 0.42f, 0.42f, 1.00f);
            style.Colors[(int)ImGuiCol.SliderGrabActive]       = new Vector4(0.42f, 0.42f, 0.42f, 1.00f);
            style.Colors[(int)ImGuiCol.Button]                 = new Vector4(0.00f, 0.00f, 0.00f, 0.00f);
            style.Colors[(int)ImGuiCol.ButtonHovered]          = new Vector4(0.00f, 0.00f, 0.00f, 0.00f);
            style.Colors[(int)ImGuiCol.ButtonActive]           = new Vector4(0.00f, 0.00f, 0.00f, 0.00f);
            style.Colors[(int)ImGuiCol.Header]                 = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            style.Colors[(int)ImGuiCol.HeaderHovered]          = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            style.Colors[(int)ImGuiCol.HeaderActive]           = new Vector4(1.00f, 0.49f, 0.11f, 1.00f);
            style.Colors[(int)ImGuiCol.Separator]              = new Vector4(1.00f, 1.00f, 1.00f, 0.50f);
            style.Colors[(int)ImGuiCol.SeparatorHovered]       = new Vector4(1.00f, 1.00f, 1.00f, 0.50f);
            style.Colors[(int)ImGuiCol.SeparatorActive]        = new Vector4(1.00f, 1.00f, 1.00f, 0.50f);
            style.Colors[(int)ImGuiCol.ResizeGrip]             = new Vector4(1.00f, 1.00f, 1.00f, 1.00f);
            style.Colors[(int)ImGuiCol.ResizeGripHovered]      = new Vector4(1.00f, 1.00f, 1.00f, 1.00f);
            style.Colors[(int)ImGuiCol.ResizeGripActive]       = new Vector4(1.00f, 1.00f, 1.00f, 1.00f);
            style.Colors[(int)ImGuiCol.Tab]                    = new Vector4(0.00f, 0.00f, 0.00f, 0.00f);
            style.Colors[(int)ImGuiCol.TabHovered]             = new Vector4(0.00f, 0.00f, 0.00f, 0.00f);
            style.Colors[(int)ImGuiCol.TabActive]              = new Vector4(0.00f, 0.00f, 0.00f, 0.00f);
            style.Colors[(int)ImGuiCol.TabUnfocused]           = new Vector4(0.00f, 0.00f, 0.00f, 0.00f);
            style.Colors[(int)ImGuiCol.TabUnfocusedActive]     = new Vector4(0.00f, 0.00f, 0.00f, 0.00f);
            style.Colors[(int)ImGuiCol.DockingPreview]         = new Vector4(0.61f, 0.61f, 0.61f, 1.00f);
            style.Colors[(int)ImGuiCol.DockingEmptyBg]         = new Vector4(1.00f, 0.43f, 0.35f, 1.00f);
            style.Colors[(int)ImGuiCol.PlotLines]              = new Vector4(0.90f, 0.70f, 0.00f, 1.00f);
            style.Colors[(int)ImGuiCol.PlotLinesHovered]       = new Vector4(1.00f, 0.60f, 0.00f, 1.00f);
            style.Colors[(int)ImGuiCol.PlotHistogram]          = new Vector4(0.26f, 0.59f, 0.98f, 0.34f);
            style.Colors[(int)ImGuiCol.PlotHistogramHovered]   = new Vector4(1.00f, 1.00f, 0.00f, 0.78f);
            style.Colors[(int)ImGuiCol.TableHeaderBg]          = new Vector4(0.26f, 0.59f, 0.98f, 1.00f);
            style.Colors[(int)ImGuiCol.TableBorderStrong]      = new Vector4(1.00f, 1.00f, 1.00f, 0.67f);
            style.Colors[(int)ImGuiCol.TableBorderLight]       = new Vector4(0.80f, 0.80f, 0.80f, 0.31f);
            style.Colors[(int)ImGuiCol.TableRowBg]             = new Vector4(0.80f, 0.80f, 0.80f, 0.38f);
            style.Colors[(int)ImGuiCol.TableRowBgAlt]          = new Vector4(0.80f, 0.80f, 0.80f, 1.00f);
            style.Colors[(int)ImGuiCol.TextSelectedBg]         = new Vector4(1.00f, 0.49f, 0.11f, 1.00f);
            style.Colors[(int)ImGuiCol.DragDropTarget]         = new Vector4(1.00f, 0.49f, 0.11f, 1.00f);
            style.Colors[(int)ImGuiCol.NavHighlight]           = new Vector4(1.00f, 0.00f, 0.94f, 1.00f);
            style.Colors[(int)ImGuiCol.NavWindowingHighlight]  = new Vector4(1.00f, 0.00f, 0.69f, 1.00f);
            style.Colors[(int)ImGuiCol.NavWindowingDimBg]      = new Vector4(0.12f, 0.00f, 1.00f, 1.00f);
            style.Colors[(int)ImGuiCol.ModalWindowDimBg]       = new Vector4(0.00f, 0.00f, 1.00f, 1.00f);
        }
    #endregion

        static bool demo_Checkbox = false;
        static string demo_StringField = "";
        public static void ShowDemoWindow(ref bool visible) {
            if (ImVGui.Begin("VGui Controls Demo", ref visible)) {
				ImGui.Text("VGui Styles");
				if (ImVGui.Button("Engine Tools")) {
					ImVGui.StyleEngineTools();
				}
				ImGui.SameLine();
				if (ImVGui.Button("Steam Green")) {
					ImVGui.StyleSteamGreen();
				}
				ImGui.SameLine();
				if (ImVGui.Button("Source Gray")) {
					ImVGui.StyleSourceGray();
				}

				ImGui.Separator();
				ImGui.Text("VGui Controls");

				if (ImVGui.Button("Button")) {
					Debug.Log("Pressed Button");
				}

				ImVGui.InputText("Text Input", ref demo_StringField, 1024);

				ImVGui.Checkbox("Checkbox", ref demo_Checkbox);

				ImVGui.End();
			}
        }

        public static void ShowDemoWindow() {
            bool visible = true;
            ShowDemoWindow(ref visible);
        }

        public static void InsetBorder(Vector2 topLeft, Vector2 bottomRight) {
            Vector4 borderCol = ImGui.GetStyle().Colors[(int)ImGuiCol.Border];
            Vector4 borderDarkCol = ImGui.GetStyle().Colors[(int)ImGuiCol.BorderShadow];

            ImDrawListPtr drawList = ImGui.GetForegroundDrawList();
            drawList.AddLine(topLeft, new Vector2(bottomRight.x, topLeft.y),
                            ImGui.GetColorU32(borderDarkCol));
            drawList.AddLine(topLeft, new Vector2(topLeft.x, bottomRight.y),
                            ImGui.GetColorU32(borderDarkCol));

            drawList.AddLine(new Vector2(topLeft.x, bottomRight.y), bottomRight + new Vector2(1.0f, 0.0f),
                            ImGui.GetColorU32(borderCol));
            drawList.AddLine(bottomRight + new Vector2(0.0f, 1.0f), new Vector2(bottomRight.x, topLeft.y),
                            ImGui.GetColorU32(borderCol));
        }

        public static void OutsetBorder(Vector2 topLeft, Vector2 bottomRight) {
            Vector4 borderCol = ImGui.GetStyle().Colors[(int)ImGuiCol.Border];
            Vector4 borderDarkCol = ImGui.GetStyle().Colors[(int)ImGuiCol.BorderShadow];

            ImDrawListPtr drawList = ImGui.GetForegroundDrawList();
            drawList.AddLine(topLeft, new Vector2(bottomRight.x, topLeft.y),
                            ImGui.GetColorU32(borderCol));
            drawList.AddLine(topLeft, new Vector2(topLeft.x, bottomRight.y),
                            ImGui.GetColorU32(borderCol));
            drawList.AddLine(new Vector2(topLeft.x, bottomRight.y), bottomRight + new Vector2(1.0f, 0.0f),
                            ImGui.GetColorU32(borderDarkCol));
            drawList.AddLine(bottomRight + new Vector2(0.0f, 1.0f), new Vector2(bottomRight.x, topLeft.y),
                            ImGui.GetColorU32(borderDarkCol));
                            
        }

        public static bool Begin(string label) {
            ImGui.PushStyleVar(ImGuiStyleVar.WindowBorderSize, 0);

            bool visible = true;
            bool ret = ImGui.Begin(label, ref visible, ImGuiWindowFlags.NoTitleBar);
            
            ImGui.PopStyleVar();

            if (ret) {
                ImGui.SetCursorPos(new Vector2(ImGui.GetStyle().WindowTitleAlign.x * 100, 12));
                ImGui.Text(label);
            }

            return ret;
        }

        public static bool Begin(string label, ref bool visible, ImGuiWindowFlags flags = ImGuiWindowFlags.None) {
            ImGui.PushStyleVar(ImGuiStyleVar.WindowBorderSize, 0);

            bool ret = ImGui.Begin(label, ref visible, flags | ImGuiWindowFlags.NoTitleBar);
            
            ImGui.PopStyleVar();

            // don't draw our custom titlebar if we don't have a titlebar
            if (ret && !flags.HasFlag(ImGuiWindowFlags.NoTitleBar)) {
                var closePosition = new Vector2(ImGui.GetWindowSize().x - 36, 7);
            
                ImGui.SetCursorPos(new Vector2(ImGui.GetStyle().WindowTitleAlign.x * 100, 12));
                ImGui.Text(label);

                var prevPosition = ImGui.GetCursorPos();

                ImGui.PushStyleVar(ImGuiStyleVar.WindowPadding, new Vector2(0, 0));

                ImGui.SetCursorPos(closePosition);
                if (Button($"X##{label}", new Vector2(24, 24))) {
                    visible = false;
                }

                ImGui.PopStyleVar();

                ImGui.SetCursorPos(prevPosition + new Vector2(0.0f, 14.0f));
            }

            return ret;
        }

        public static void End() {
            if (ImGui.GetStyle().WindowBorderSize > 0)
                OutsetBorder(ImGui.GetWindowPos(), ImGui.GetWindowPos() + ImGui.GetWindowSize() - new Vector2(1.0f, 1.0f));

            ImGui.End();
        }

        public static bool Button(string text) {
            if (buttonUseSelectionColor) {
                Vector4 textCol = ImGui.GetStyle().Colors[(int)ImGuiCol.TextSelectedBg];
                ImGui.PushStyleColor(ImGuiCol.Text, textCol);
            }
            
            // Set Button padding
            ImGui.PushStyleVar(ImGuiStyleVar.FramePadding, new Vector2(5.0f, 6.0f));
            ImGui.PushStyleVar(ImGuiStyleVar.FrameBorderSize, 0);

            bool pressed = ImGui.Button(text);
            
            if (buttonUseSelectionColor)
                ImGui.PopStyleColor();
            ImGui.PopStyleVar(2);

            // Draw Border
            if (ImGui.IsItemHovered() && ImGui.IsMouseDown(ImGuiMouseButton.Left)) {
                InsetBorder(ImGui.GetItemRectMin(), ImGui.GetItemRectMax());
            } else {
                OutsetBorder(ImGui.GetItemRectMin(), ImGui.GetItemRectMax());
            }

            return pressed;
        }

        public static bool Button(string text, Vector2 size) {
            if (buttonUseSelectionColor) {
                Vector4 textCol = ImGui.GetStyle().Colors[(int)ImGuiCol.TextSelectedBg];
                ImGui.PushStyleColor(ImGuiCol.Text, textCol);
            }
            
            // Set Button padding
            ImGui.PushStyleVar(ImGuiStyleVar.FramePadding, new Vector2(5.0f, 6.0f));
            ImGui.PushStyleVar(ImGuiStyleVar.FrameBorderSize, 0);

            bool pressed = ImGui.Button(text, size);
            
            if (buttonUseSelectionColor)
                ImGui.PopStyleColor();
            ImGui.PopStyleVar(2);

            // Draw Border
            if (ImGui.IsItemHovered() && ImGui.IsMouseDown(ImGuiMouseButton.Left)) {
                InsetBorder(ImGui.GetItemRectMin(), ImGui.GetItemRectMax());
            } else {
                OutsetBorder(ImGui.GetItemRectMin(), ImGui.GetItemRectMax());
            }

            return pressed;
        }

        public static bool InputText(string label, ref string input, uint charLimit) {
            ImGui.PushStyleVar(ImGuiStyleVar.FrameBorderSize, 0);
            
            ImGui.Text(label);
            ImGui.SameLine();
            bool ret = ImGui.InputText($"##{label}", ref input, charLimit);
            
            ImGui.PopStyleVar();

            InsetBorder(ImGui.GetItemRectMin(), ImGui.GetItemRectMax());

            return ret;
        }

        public static bool Checkbox(string label, ref bool v) {
            ImGui.PushStyleVar(ImGuiStyleVar.FrameBorderSize, 0);

            var ret = ImGui.Checkbox($"##{label}", ref v);

            ImGui.PopStyleVar();

            ImDrawListPtr drawList = ImGui.GetForegroundDrawList();
            Vector2 topLeft = ImGui.GetItemRectMin();
            Vector2 bottomRight = ImGui.GetItemRectMax();
            drawList.AddLine(new Vector2(topLeft.x, bottomRight.y), bottomRight + new Vector2(1.0f, 0.0f),
                            ImGui.GetColorU32(new Vector4(0.71f, 0.71f, 0.71f, 1.0f)));
            drawList.AddLine(bottomRight + new Vector2(0.0f, 1.0f), new Vector2(bottomRight.x, topLeft.y),
                            ImGui.GetColorU32(new Vector4(0.71f, 0.71f, 0.71f, 1.0f)));

            ImGui.SameLine();
            ImGui.Text(label);

            return ret;
        }
    }
}
