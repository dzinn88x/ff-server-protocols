using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020013BC RID: 5052
	[Token(Token = "0x20013BC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBCB8", Offset = "0x10EBCB8")]
	public class UISuperCarHelpWndItemController : UIBaseController
	{
		// Token: 0x06005265 RID: 21093 RVA: 0x00018C18 File Offset: 0x00016E18
		[Token(Token = "0x6005265")]
		[Address(RVA = "0x214539C", Offset = "0x214539C", VA = "0x7BBC94539C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005266 RID: 21094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005266")]
		[Address(RVA = "0x21453EC", Offset = "0x21453EC", VA = "0x7BBC9453EC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005267 RID: 21095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005267")]
		[Address(RVA = "0x2145674", Offset = "0x2145674", VA = "0x7BBC945674")]
		private void OnBtnGetSkinClick()
		{
		}

		// Token: 0x06005268 RID: 21096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005268")]
		[Address(RVA = "0x2145788", Offset = "0x2145788", VA = "0x7BBC945788")]
		private void OnBtnInviteClick()
		{
		}

		// Token: 0x06005269 RID: 21097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005269")]
		[Address(RVA = "0x2144D68", Offset = "0x2144D68", VA = "0x7BBC944D68")]
		public void SetData(SupercarHelpPlayer helper)
		{
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600526A")]
		[Address(RVA = "0x21458C8", Offset = "0x21458C8", VA = "0x7BBC9458C8")]
		public UISuperCarHelpWndItemController()
		{
		}

		// Token: 0x04007866 RID: 30822
		[Token(Token = "0x4007866")]
		[FieldOffset(Offset = "0x58")]
		private UISuperCarHelpWndItemView m_View;

		// Token: 0x04007867 RID: 30823
		[Token(Token = "0x4007867")]
		[FieldOffset(Offset = "0x60")]
		private UIModelSuperCar m_ModelSuperCar;

		// Token: 0x04007868 RID: 30824
		[Token(Token = "0x4007868")]
		[FieldOffset(Offset = "0x68")]
		private SupercarSettingDesc m_SuperCarSetting;

		// Token: 0x04007869 RID: 30825
		[Token(Token = "0x4007869")]
		[FieldOffset(Offset = "0x70")]
		private SupercarHelpPlayer data;

		// Token: 0x0400786A RID: 30826
		[Token(Token = "0x400786A")]
		[FieldOffset(Offset = "0x78")]
		private uint gopos;
	}
}
