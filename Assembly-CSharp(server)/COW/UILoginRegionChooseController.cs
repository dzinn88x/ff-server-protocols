using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A2A RID: 6698
	[Token(Token = "0x2001A2A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7A7C", Offset = "0x10F7A7C")]
	public class UILoginRegionChooseController : UIPopupWindowController
	{
		// Token: 0x06008C7D RID: 35965 RVA: 0x000257D0 File Offset: 0x000239D0
		[Token(Token = "0x6008C7D")]
		[Address(RVA = "0x19E81C4", Offset = "0x19E81C4", VA = "0x7BBC1E81C4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008C7E RID: 35966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C7E")]
		[Address(RVA = "0x19E8214", Offset = "0x19E8214", VA = "0x7BBC1E8214", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008C7F RID: 35967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C7F")]
		[Address(RVA = "0x19E4E40", Offset = "0x19E4E40", VA = "0x7BBC1E4E40")]
		public void SetData(List<string> serverList)
		{
		}

		// Token: 0x06008C80 RID: 35968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C80")]
		[Address(RVA = "0x19E5128", Offset = "0x19E5128", VA = "0x7BBC1E5128")]
		public void SetTitle(string title)
		{
		}

		// Token: 0x06008C81 RID: 35969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C81")]
		[Address(RVA = "0x19E84A4", Offset = "0x19E84A4", VA = "0x7BBC1E84A4")]
		private void OnBtnConfirmClick()
		{
		}

		// Token: 0x06008C82 RID: 35970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C82")]
		[Address(RVA = "0x19E8950", Offset = "0x19E8950", VA = "0x7BBC1E8950")]
		private void BtnConfirm()
		{
		}

		// Token: 0x06008C83 RID: 35971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C83")]
		[Address(RVA = "0x19E8A10", Offset = "0x19E8A10", VA = "0x7BBC1E8A10")]
		private void BtnCancel()
		{
		}

		// Token: 0x06008C84 RID: 35972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C84")]
		[Address(RVA = "0x19E8A20", Offset = "0x19E8A20", VA = "0x7BBC1E8A20")]
		public UILoginRegionChooseController()
		{
		}

		// Token: 0x06008C85 RID: 35973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C85")]
		[Address(RVA = "0x19E8A28", Offset = "0x19E8A28", VA = "0x7BBC1E8A28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144348", Offset = "0x1144348")]
		private void <OnBtnConfirmClick>b__10_0()
		{
		}

		// Token: 0x06008C86 RID: 35974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C86")]
		[Address(RVA = "0x19E8A2C", Offset = "0x19E8A2C", VA = "0x7BBC1E8A2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144358", Offset = "0x1144358")]
		private void <OnBtnConfirmClick>b__10_1()
		{
		}

		// Token: 0x040098F8 RID: 39160
		[Token(Token = "0x40098F8")]
		[FieldOffset(Offset = "0x98")]
		private UILoginRegionChooseView m_View;

		// Token: 0x040098F9 RID: 39161
		[Token(Token = "0x40098F9")]
		[FieldOffset(Offset = "0xA0")]
		private List<string> m_ServerList;

		// Token: 0x040098FA RID: 39162
		[Token(Token = "0x40098FA")]
		[FieldOffset(Offset = "0xA8")]
		private List<UILabel> m_LableList;

		// Token: 0x040098FB RID: 39163
		[Token(Token = "0x40098FB")]
		[FieldOffset(Offset = "0xB0")]
		private List<UIToggle> m_ToggleList;

		// Token: 0x040098FC RID: 39164
		[Token(Token = "0x40098FC")]
		[FieldOffset(Offset = "0xB8")]
		private string m_SelectedServer;

		// Token: 0x040098FD RID: 39165
		[Token(Token = "0x40098FD")]
		private const int SERVER_COUNT = 3;
	}
}
