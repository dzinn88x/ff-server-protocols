using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001768 RID: 5992
	[Token(Token = "0x2001768")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1FF4", Offset = "0x10F1FF4")]
	public class UICommonTipsController : UIPopupWindowController
	{
		// Token: 0x06007104 RID: 28932 RVA: 0x0001F980 File Offset: 0x0001DB80
		[Token(Token = "0x6007104")]
		[Address(RVA = "0x1815D48", Offset = "0x1815D48", VA = "0x7BBC015D48")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007105 RID: 28933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007105")]
		[Address(RVA = "0x1815D98", Offset = "0x1815D98", VA = "0x7BBC015D98", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007106 RID: 28934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007106")]
		[Address(RVA = "0x1815EB0", Offset = "0x1815EB0", VA = "0x7BBC015EB0")]
		public void ShowTips([Optional] List<string> list)
		{
		}

		// Token: 0x06007107 RID: 28935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007107")]
		[Address(RVA = "0x1815F40", Offset = "0x1815F40", VA = "0x7BBC015F40")]
		public void ShowTipsAtPosition(List<string> list, float postionX, float postionY)
		{
		}

		// Token: 0x06007108 RID: 28936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007108")]
		[Address(RVA = "0x1816284", Offset = "0x1816284", VA = "0x7BBC016284", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007109 RID: 28937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007109")]
		[Address(RVA = "0x18162C0", Offset = "0x18162C0", VA = "0x7BBC0162C0")]
		public UICommonTipsController()
		{
		}

		// Token: 0x04008AB1 RID: 35505
		[Token(Token = "0x4008AB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UICommonTipsView m_View;

		// Token: 0x04008AB2 RID: 35506
		[Token(Token = "0x4008AB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector2 m_showOffset;

		// Token: 0x04008AB3 RID: 35507
		[Token(Token = "0x4008AB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int m_Width;

		// Token: 0x04008AB4 RID: 35508
		[Token(Token = "0x4008AB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int m_Height;

		// Token: 0x04008AB5 RID: 35509
		[Token(Token = "0x4008AB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float m_scale;

		// Token: 0x04008AB6 RID: 35510
		[Token(Token = "0x4008AB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private UIClickMask m_ClickMask;
	}
}
