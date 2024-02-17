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
    #region Style Colors
        public static void StyleEngineTools() {
            var colors = ImGui.GetStyle().Colors;
            colors[(int)ImGuiCol.Text]                   = new Vector4(1.00f, 1.00f, 1.00f, 1.00f);
            colors[(int)ImGuiCol.TextDisabled]           = new Vector4(0.50f, 0.50f, 0.50f, 1.00f);
            colors[(int)ImGuiCol.WindowBg]               = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            colors[(int)ImGuiCol.ChildBg]                = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            colors[(int)ImGuiCol.PopupBg]                = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            colors[(int)ImGuiCol.Border]                 = new Vector4(0.71f, 0.71f, 0.71f, 1.00f);
            colors[(int)ImGuiCol.BorderShadow]           = new Vector4(0.00f, 0.00f, 0.00f, 0.60f);
            colors[(int)ImGuiCol.FrameBg]                = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            colors[(int)ImGuiCol.FrameBgHovered]         = new Vector4(1.00f, 0.49f, 0.11f, 0.54f);
            colors[(int)ImGuiCol.FrameBgActive]          = new Vector4(1.00f, 0.49f, 0.11f, 1.00f);
            colors[(int)ImGuiCol.TitleBg]                = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            colors[(int)ImGuiCol.TitleBgActive]          = new Vector4(0.34f, 0.34f, 0.34f, 1.00f);
            colors[(int)ImGuiCol.TitleBgCollapsed]       = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            colors[(int)ImGuiCol.MenuBarBg]              = new Vector4(0.20f, 0.20f, 0.20f, 1.00f);
            colors[(int)ImGuiCol.ScrollbarBg]            = new Vector4(0.02f, 0.02f, 0.02f, 0.52f);
            colors[(int)ImGuiCol.ScrollbarGrab]          = new Vector4(0.31f, 0.31f, 0.31f, 1.00f);
            colors[(int)ImGuiCol.ScrollbarGrabHovered]   = new Vector4(0.41f, 0.41f, 0.41f, 1.00f);
            colors[(int)ImGuiCol.ScrollbarGrabActive]    = new Vector4(0.51f, 0.51f, 0.51f, 1.00f);
            colors[(int)ImGuiCol.CheckMark]              = new Vector4(1.00f, 1.00f, 1.00f, 1.00f);
            colors[(int)ImGuiCol.SliderGrab]             = new Vector4(1.00f, 0.49f, 0.11f, 0.54f);
            colors[(int)ImGuiCol.SliderGrabActive]       = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            colors[(int)ImGuiCol.Button]                 = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            colors[(int)ImGuiCol.ButtonHovered]          = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            colors[(int)ImGuiCol.ButtonActive]           = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            colors[(int)ImGuiCol.Header]                 = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            colors[(int)ImGuiCol.HeaderHovered]          = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            colors[(int)ImGuiCol.HeaderActive]           = new Vector4(1.00f, 0.49f, 0.11f, 1.00f);
            colors[(int)ImGuiCol.Separator]              = new Vector4(0.43f, 0.43f, 0.50f, 0.41f);
            colors[(int)ImGuiCol.SeparatorHovered]       = new Vector4(1.00f, 0.49f, 0.11f, 0.34f);
            colors[(int)ImGuiCol.SeparatorActive]        = new Vector4(1.00f, 0.49f, 0.11f, 1.00f);
            colors[(int)ImGuiCol.ResizeGrip]             = new Vector4(1.00f, 0.49f, 0.11f, 0.34f);
            colors[(int)ImGuiCol.ResizeGripHovered]      = new Vector4(1.00f, 0.49f, 0.11f, 0.80f);
            colors[(int)ImGuiCol.ResizeGripActive]       = new Vector4(1.00f, 0.49f, 0.11f, 1.00f);
            colors[(int)ImGuiCol.Tab]                    = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            colors[(int)ImGuiCol.TabHovered]             = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            colors[(int)ImGuiCol.TabActive]              = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            colors[(int)ImGuiCol.TabUnfocused]           = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            colors[(int)ImGuiCol.TabUnfocusedActive]     = new Vector4(0.25f, 0.25f, 0.25f, 1.00f);
            colors[(int)ImGuiCol.DockingPreview]         = new Vector4(0.61f, 0.61f, 0.61f, 1.00f);
            colors[(int)ImGuiCol.DockingEmptyBg]         = new Vector4(1.00f, 0.43f, 0.35f, 1.00f);
            colors[(int)ImGuiCol.PlotLines]              = new Vector4(0.90f, 0.70f, 0.00f, 1.00f);
            colors[(int)ImGuiCol.PlotLinesHovered]       = new Vector4(1.00f, 0.60f, 0.00f, 1.00f);
            colors[(int)ImGuiCol.PlotHistogram]          = new Vector4(0.26f, 0.59f, 0.98f, 0.34f);
            colors[(int)ImGuiCol.PlotHistogramHovered]   = new Vector4(1.00f, 1.00f, 0.00f, 0.78f);
            colors[(int)ImGuiCol.TableHeaderBg]          = new Vector4(0.26f, 0.59f, 0.98f, 1.00f);
            colors[(int)ImGuiCol.TableBorderStrong]      = new Vector4(1.00f, 1.00f, 1.00f, 0.67f);
            colors[(int)ImGuiCol.TableBorderLight]       = new Vector4(0.80f, 0.80f, 0.80f, 0.31f);
            colors[(int)ImGuiCol.TableRowBg]             = new Vector4(0.80f, 0.80f, 0.80f, 0.38f);
            colors[(int)ImGuiCol.TableRowBgAlt]          = new Vector4(0.80f, 0.80f, 0.80f, 1.00f);
            colors[(int)ImGuiCol.TextSelectedBg]         = new Vector4(1.00f, 0.49f, 0.11f, 1.00f);
            colors[(int)ImGuiCol.DragDropTarget]         = new Vector4(1.00f, 0.49f, 0.11f, 1.00f);
            colors[(int)ImGuiCol.NavHighlight]           = new Vector4(1.00f, 0.00f, 0.94f, 1.00f);
            colors[(int)ImGuiCol.NavWindowingHighlight]  = new Vector4(1.00f, 0.00f, 0.69f, 1.00f);
            colors[(int)ImGuiCol.NavWindowingDimBg]      = new Vector4(0.12f, 0.00f, 1.00f, 1.00f);
            colors[(int)ImGuiCol.ModalWindowDimBg]       = new Vector4(0.00f, 0.00f, 1.00f, 1.00f);
        }

        public static void StyleSteamGreen() {

        }
    #endregion

        public static void InsetBorder(Vector2 topLeft, Vector2 bottomRight) {
            ImDrawListPtr drawList = ImGui.GetForegroundDrawList();
            drawList.AddLine(topLeft, new Vector2(bottomRight.x, topLeft.y),
                            ImGui.GetColorU32(new Vector4(0.0f, 0.0f, 0.0f, 1.0f)));
            drawList.AddLine(topLeft, new Vector2(topLeft.x, bottomRight.y),
                            ImGui.GetColorU32(new Vector4(0.0f, 0.0f, 0.0f, 1.0f)));

            drawList.AddLine(new Vector2(topLeft.x, bottomRight.y), bottomRight + new Vector2(1.0f, 0.0f),
                            ImGui.GetColorU32(new Vector4(0.71f, 0.71f, 0.71f, 1.0f)));
            drawList.AddLine(bottomRight + new Vector2(0.0f, 1.0f), new Vector2(bottomRight.x, topLeft.y),
                            ImGui.GetColorU32(new Vector4(0.71f, 0.71f, 0.71f, 1.0f)));
        }

        public static void OutsetBorder(Vector2 topLeft, Vector2 bottomRight) {
            ImDrawListPtr drawList = ImGui.GetForegroundDrawList();
            drawList.AddLine(topLeft, new Vector2(bottomRight.x, topLeft.y),
                            ImGui.GetColorU32(new Vector4(0.71f, 0.71f, 0.71f, 1.0f)));
            drawList.AddLine(topLeft, new Vector2(topLeft.x, bottomRight.y),
                            ImGui.GetColorU32(new Vector4(0.71f, 0.71f, 0.71f, 1.0f)));
            drawList.AddLine(new Vector2(topLeft.x, bottomRight.y), bottomRight + new Vector2(1.0f, 0.0f),
                            ImGui.GetColorU32(new Vector4(0.0f, 0.0f, 0.0f, 1.0f)));
            drawList.AddLine(bottomRight + new Vector2(0.0f, 1.0f), new Vector2(bottomRight.x, topLeft.y),
                            ImGui.GetColorU32(new Vector4(0.0f, 0.0f, 0.0f, 1.0f)));
                            
        }

        public static bool Begin(string label) {
            ImGui.PushStyleColor(ImGuiCol.Border, new Vector4(0.251f, 0.251f, 0.251f, 1.000f));
            ImGui.PushStyleColor(ImGuiCol.BorderShadow, new Vector4(0.251f, 0.251f, 0.251f, 1.000f));
            ImGui.PushStyleVar(ImGuiStyleVar.WindowPadding, new Vector2(14.0f, 14.0f));
            ImGui.PushStyleVar(ImGuiStyleVar.WindowRounding, 0);

            bool ret = ImGui.Begin(label);

            ImGui.PopStyleColor(2);
            ImGui.PopStyleVar(2);

            return ret;
        }

        public static bool Begin(string label, ref bool visible, ImGuiWindowFlags flags = ImGuiWindowFlags.None) {
            ImGui.PushStyleColor(ImGuiCol.Border, new Vector4(0.251f, 0.251f, 0.251f, 1.000f));
            ImGui.PushStyleColor(ImGuiCol.BorderShadow, new Vector4(0.251f, 0.251f, 0.251f, 1.000f));
            ImGui.PushStyleVar(ImGuiStyleVar.WindowPadding, new Vector2(14.0f, 14.0f));
            ImGui.PushStyleVar(ImGuiStyleVar.WindowRounding, 0);

            bool ret = ImGui.Begin(label, ref visible, flags);

            ImGui.PopStyleColor(2);
            ImGui.PopStyleVar(2);

            return ret;
        }

        public static void End() {
            OutsetBorder(ImGui.GetWindowPos(), ImGui.GetWindowPos() + ImGui.GetWindowSize() - new Vector2(1.0f, 1.0f));

            ImGui.End();
        }

        public static bool Button(string text) {
            ImGui.PushStyleColor(ImGuiCol.Text, new Vector4(1.000f, 0.490f, 0.114f, 1.000f));
            ImGui.PushStyleColor(ImGuiCol.Border, new Vector4(0.251f, 0.251f, 0.251f, 1.000f));
            ImGui.PushStyleColor(ImGuiCol.BorderShadow, new Vector4(0.251f, 0.251f, 0.251f, 1.000f));
            
            // add some extra padding
            ImGui.PushStyleVar(ImGuiStyleVar.FramePadding, new Vector2(5.0f, 4.0f));
            ImGui.PushStyleVar(ImGuiStyleVar.FrameRounding, 0);

            bool pressed = ImGui.Button(text);
            
            ImGui.PopStyleColor(3);
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
            ImGui.PushStyleColor(ImGuiCol.FrameBg, new Vector4(0.172f, 0.172f, 0.172f, 1.000f));
            ImGui.PushStyleColor(ImGuiCol.Border, new Vector4(0.172f, 0.172f, 0.172f, 1.000f));
            ImGui.PushStyleColor(ImGuiCol.BorderShadow, new Vector4(0.172f, 0.172f, 0.172f, 1.000f));
            ImGui.PushStyleVar(ImGuiStyleVar.FrameRounding, 0);
            
            ImGui.Text(label);
            ImGui.SameLine();
            bool ret = ImGui.InputText($"##{label}", ref input, charLimit);
            
            ImGui.PopStyleColor(3);
            ImGui.PopStyleVar();

            InsetBorder(ImGui.GetItemRectMin(), ImGui.GetItemRectMax());

            return ret;
        }

        public static bool Checkbox(string label, ref bool v) {
            ImGui.PushStyleColor(ImGuiCol.FrameBg, new Vector4(0.172f, 0.172f, 0.172f, 1.000f));
            ImGui.PushStyleColor(ImGuiCol.FrameBgHovered, new Vector4(0.172f, 0.172f, 0.172f, 1.000f));
            ImGui.PushStyleColor(ImGuiCol.Border, new Vector4(0.172f, 0.172f, 0.172f, 1.000f));
            ImGui.PushStyleColor(ImGuiCol.BorderShadow, new Vector4(0.172f, 0.172f, 0.172f, 1.000f));
            ImGui.PushStyleVar(ImGuiStyleVar.FrameRounding, 0);

            var ret = ImGui.Checkbox($"##{label}", ref v);

            ImGui.PopStyleColor(4);
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
