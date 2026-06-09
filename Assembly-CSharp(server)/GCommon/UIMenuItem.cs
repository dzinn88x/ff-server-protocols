using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02001032 RID: 4146
	[Token(Token = "0x2001032")]
	public class UIMenuItem : MonoBehaviour
	{
		// Token: 0x06003ED2 RID: 16082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED2")]
		[Address(RVA = "0x203011C", Offset = "0x203011C", VA = "0x7BBC83011C")]
		private void Awake()
		{
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED3")]
		[Address(RVA = "0x2030120", Offset = "0x2030120", VA = "0x7BBC830120")]
		private void Start()
		{
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED4")]
		[Address(RVA = "0x2030124", Offset = "0x2030124", VA = "0x7BBC830124")]
		private void Update()
		{
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED5")]
		[Address(RVA = "0x202F3F0", Offset = "0x202F3F0", VA = "0x7BBC82F3F0")]
		public void SetMenuData(UIMenuItemData menuData)
		{
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x000137E8 File Offset: 0x000119E8
		[Token(Token = "0x6003ED6")]
		[Address(RVA = "0x2030070", Offset = "0x2030070", VA = "0x7BBC830070")]
		public bool IsMenu(string id)
		{
			return default(bool);
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED7")]
		[Address(RVA = "0x202FD88", Offset = "0x202FD88", VA = "0x7BBC82FD88")]
		public void SetSelected(bool value)
		{
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED8")]
		[Address(RVA = "0x202F0A0", Offset = "0x202F0A0", VA = "0x7BBC82F0A0")]
		public void DirectlyRunSelectCallback()
		{
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x00013800 File Offset: 0x00011A00
		[Token(Token = "0x6003ED9")]
		[Address(RVA = "0x2030128", Offset = "0x2030128", VA = "0x7BBC830128")]
		public bool Selected()
		{
			return default(bool);
		}

		// Token: 0x06003EDA RID: 16090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EDA")]
		[Address(RVA = "0x2030130", Offset = "0x2030130", VA = "0x7BBC830130")]
		public void SetParentMenu(UIMenuItem parentMenu)
		{
		}

		// Token: 0x06003EDB RID: 16091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EDB")]
		[Address(RVA = "0x2030138", Offset = "0x2030138", VA = "0x7BBC830138")]
		public UIMenuItem ParentMenu()
		{
			return null;
		}

		// Token: 0x06003EDC RID: 16092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EDC")]
		[Address(RVA = "0x202F2F4", Offset = "0x202F2F4", VA = "0x7BBC82F2F4")]
		public void SetClickCallback(Action<UIMenuItem> onClick)
		{
		}

		// Token: 0x06003EDD RID: 16093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EDD")]
		[Address(RVA = "0x2030148", Offset = "0x2030148", VA = "0x7BBC830148")]
		public UIMenuItem()
		{
		}

		// Token: 0x04004F17 RID: 20247
		[Token(Token = "0x4004F17")]
		[FieldOffset(Offset = "0x18")]
		public UILabel[] titles;

		// Token: 0x04004F18 RID: 20248
		[Token(Token = "0x4004F18")]
		[FieldOffset(Offset = "0x20")]
		public GameObject select;

		// Token: 0x04004F19 RID: 20249
		[Token(Token = "0x4004F19")]
		[FieldOffset(Offset = "0x28")]
		public GameObject unSelect;

		// Token: 0x04004F1A RID: 20250
		[Token(Token = "0x4004F1A")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget size;

		// Token: 0x04004F1B RID: 20251
		[Token(Token = "0x4004F1B")]
		[FieldOffset(Offset = "0x38")]
		public UIButton button;

		// Token: 0x04004F1C RID: 20252
		[Token(Token = "0x4004F1C")]
		[FieldOffset(Offset = "0x40")]
		public GameObject[] exObjects;

		// Token: 0x04004F1D RID: 20253
		[Token(Token = "0x4004F1D")]
		[FieldOffset(Offset = "0x48")]
		private bool m_Selected;

		// Token: 0x04004F1E RID: 20254
		[Token(Token = "0x4004F1E")]
		[FieldOffset(Offset = "0x50")]
		private UIMenuItem m_ParentMenu;

		// Token: 0x04004F1F RID: 20255
		[Token(Token = "0x4004F1F")]
		[FieldOffset(Offset = "0x58")]
		private UIMenuItemData m_MenuData;

		// Token: 0x02001033 RID: 4147
		[Token(Token = "0x2001033")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA784", Offset = "0x10EA784")]
		private sealed class <>c__DisplayClass19_0
		{
			// Token: 0x06003EDE RID: 16094 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003EDE")]
			[Address(RVA = "0x2030140", Offset = "0x2030140", VA = "0x7BBC830140")]
			public <>c__DisplayClass19_0()
			{
			}

			// Token: 0x06003EDF RID: 16095 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003EDF")]
			[Address(RVA = "0x2030150", Offset = "0x2030150", VA = "0x7BBC830150")]
			internal void <SetClickCallback>b__0()
			{
			}

			// Token: 0x04004F20 RID: 20256
			[Token(Token = "0x4004F20")]
			[FieldOffset(Offset = "0x10")]
			public Action<UIMenuItem> onClick;

			// Token: 0x04004F21 RID: 20257
			[Token(Token = "0x4004F21")]
			[FieldOffset(Offset = "0x18")]
			public UIMenuItem <>4__this;
		}
	}
}
