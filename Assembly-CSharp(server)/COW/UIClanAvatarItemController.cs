using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001718 RID: 5912
	[Token(Token = "0x2001718")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F176C", Offset = "0x10F176C")]
	public class UIClanAvatarItemController : UIEasyListItemController
	{
		// Token: 0x06006E41 RID: 28225 RVA: 0x0001F0C8 File Offset: 0x0001D2C8
		[Token(Token = "0x6006E41")]
		[Address(RVA = "0x1CEAF6C", Offset = "0x1CEAF6C", VA = "0x7BBC4EAF6C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006E42 RID: 28226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E42")]
		[Address(RVA = "0x1CEAFBC", Offset = "0x1CEAFBC", VA = "0x7BBC4EAFBC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006E43 RID: 28227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E43")]
		[Address(RVA = "0x1CEB0A0", Offset = "0x1CEB0A0", VA = "0x7BBC4EB0A0", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006E44 RID: 28228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E44")]
		[Address(RVA = "0x1CEB194", Offset = "0x1CEB194", VA = "0x7BBC4EB194")]
		private void SelectAvatar()
		{
		}

		// Token: 0x06006E45 RID: 28229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E45")]
		[Address(RVA = "0x1CEB2A8", Offset = "0x1CEB2A8", VA = "0x7BBC4EB2A8")]
		public UIClanAvatarItemController()
		{
		}

		// Token: 0x040088EF RID: 35055
		[Token(Token = "0x40088EF")]
		[FieldOffset(Offset = "0x70")]
		private UIClanAvatarItemView m_View;

		// Token: 0x040088F0 RID: 35056
		[Token(Token = "0x40088F0")]
		[FieldOffset(Offset = "0x78")]
		private HeadPicBaseInfo m_ClanAvatarInfo;
	}
}
