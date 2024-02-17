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
        public static void StyleEngineTools() {

        }

        public static void StyleSteamGreen() {

        }

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

            bool ret = ImGui.Begin(label);

            ImGui.PopStyleColor(2);
            ImGui.PopStyleVar();

            return ret;
        }

        public static bool Begin(string label, ref bool visible, ImGuiWindowFlags flags = ImGuiWindowFlags.None) {
            ImGui.PushStyleColor(ImGuiCol.Border, new Vector4(0.251f, 0.251f, 0.251f, 1.000f));
            ImGui.PushStyleColor(ImGuiCol.BorderShadow, new Vector4(0.251f, 0.251f, 0.251f, 1.000f));
            ImGui.PushStyleVar(ImGuiStyleVar.WindowPadding, new Vector2(14.0f, 14.0f));

            bool ret = ImGui.Begin(label, ref visible, flags);

            ImGui.PopStyleColor(2);

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

            bool pressed = ImGui.Button(text);
            
            ImGui.PopStyleColor(3);
            ImGui.PopStyleVar();

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
            
            ImGui.Text(label);
            ImGui.SameLine();
            bool ret = ImGui.InputText($"##{label}", ref input, charLimit);
            
            ImGui.PopStyleColor(3);

            InsetBorder(ImGui.GetItemRectMin(), ImGui.GetItemRectMax());

            return ret;
        }

        public static bool Checkbox(string label, ref bool v) {
            ImGui.PushStyleColor(ImGuiCol.FrameBg, new Vector4(0.172f, 0.172f, 0.172f, 1.000f));
            ImGui.PushStyleColor(ImGuiCol.FrameBgHovered, new Vector4(0.172f, 0.172f, 0.172f, 1.000f));
            ImGui.PushStyleColor(ImGuiCol.Border, new Vector4(0.172f, 0.172f, 0.172f, 1.000f));
            ImGui.PushStyleColor(ImGuiCol.BorderShadow, new Vector4(0.172f, 0.172f, 0.172f, 1.000f));

            var ret = ImGui.Checkbox($"##{label}", ref v);

            ImGui.PopStyleColor(4);

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
