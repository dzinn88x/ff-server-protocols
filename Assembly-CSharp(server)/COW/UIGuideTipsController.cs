using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200185A RID: 6234
	[Token(Token = "0x200185A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3E24", Offset = "0x10F3E24")]
	internal class UIGuideTipsController : UIPopupWindowController
	{
		// Token: 0x06007AC2 RID: 31426 RVA: 0x00021C90 File Offset: 0x0001FE90
		[Token(Token = "0x6007AC2")]
		[Address(RVA = "0x16AD020", Offset = "0x16AD020", VA = "0x7BBBEAD020")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007AC3 RID: 31427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AC3")]
		[Address(RVA = "0x16AD070", Offset = "0x16AD070", VA = "0x7BBBEAD070", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007AC4 RID: 31428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AC4")]
		[Address(RVA = "0x16AD0FC", Offset = "0x16AD0FC", VA = "0x7BBBEAD0FC")]
		public void SetData(string msg)
		{
		}

		// Token: 0x06007AC5 RID: 31429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AC5")]
		[Address(RVA = "0x16AD270", Offset = "0x16AD270", VA = "0x7BBBEAD270", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007AC6 RID: 31430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AC6")]
		[Address(RVA = "0x16AD318", Offset = "0x16AD318", VA = "0x7BBBEAD318")]
		public UIGuideTipsController()
		{
		}

		// Token: 0x06007AC7 RID: 31431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AC7")]
		[Address(RVA = "0x16AD320", Offset = "0x16AD320", VA = "0x7BBBEAD320")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11424B4", Offset = "0x11424B4")]
		private void <SetData>b__4_0()
		{
		}

		// Token: 0x04008F5A RID: 36698
		[Token(Token = "0x4008F5A")]
		[FieldOffset(Offset = "0x94")]
		private uint m_TipsCall;

		// Token: 0x04008F5B RID: 36699
		[Token(Token = "0x4008F5B")]
		[FieldOffset(Offset = "0x98")]
		private UIGuideTipsView m_View;
	}
}
