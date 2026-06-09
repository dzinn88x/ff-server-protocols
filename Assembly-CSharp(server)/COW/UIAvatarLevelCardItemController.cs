using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016A8 RID: 5800
	[Token(Token = "0x20016A8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F08B4", Offset = "0x10F08B4")]
	public class UIAvatarLevelCardItemController : UIBaseController
	{
		// Token: 0x060069C6 RID: 27078 RVA: 0x0001DF58 File Offset: 0x0001C158
		[Token(Token = "0x60069C6")]
		[Address(RVA = "0x1B25A70", Offset = "0x1B25A70", VA = "0x7BBC325A70")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060069C7 RID: 27079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069C7")]
		[Address(RVA = "0x1B25AC0", Offset = "0x1B25AC0", VA = "0x7BBC325AC0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060069C8 RID: 27080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069C8")]
		[Address(RVA = "0x1B25C10", Offset = "0x1B25C10", VA = "0x7BBC325C10")]
		private void OnItemClick()
		{
		}

		// Token: 0x060069C9 RID: 27081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069C9")]
		[Address(RVA = "0x1B25BB0", Offset = "0x1B25BB0", VA = "0x7BBC325BB0")]
		public void SetSelect(bool _b)
		{
		}

		// Token: 0x060069CA RID: 27082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069CA")]
		[Address(RVA = "0x1B25D48", Offset = "0x1B25D48", VA = "0x7BBC325D48")]
		public void SetData(AvatarLevelUpCard data, bool usable)
		{
		}

		// Token: 0x060069CB RID: 27083 RVA: 0x0001DF70 File Offset: 0x0001C170
		[Token(Token = "0x60069CB")]
		[Address(RVA = "0x1B25F98", Offset = "0x1B25F98", VA = "0x7BBC325F98")]
		public int GetID()
		{
			return 0;
		}

		// Token: 0x060069CC RID: 27084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069CC")]
		[Address(RVA = "0x1B25FB0", Offset = "0x1B25FB0", VA = "0x7BBC325FB0")]
		public UIAvatarLevelCardItemController()
		{
		}

		// Token: 0x04008685 RID: 34437
		[Token(Token = "0x4008685")]
		[FieldOffset(Offset = "0x58")]
		private UIAvatarLevelCardItemView m_View;

		// Token: 0x04008686 RID: 34438
		[Token(Token = "0x4008686")]
		[FieldOffset(Offset = "0x60")]
		private AvatarLevelUpCard m_CardItem;
	}
}
