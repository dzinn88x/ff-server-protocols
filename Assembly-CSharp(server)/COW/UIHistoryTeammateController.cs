using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001862 RID: 6242
	[Token(Token = "0x2001862")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3EEC", Offset = "0x10F3EEC")]
	public class UIHistoryTeammateController : UIBaseController
	{
		// Token: 0x06007B00 RID: 31488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B00")]
		[Address(RVA = "0x1D6033C", Offset = "0x1D6033C", VA = "0x7BBC56033C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007B01 RID: 31489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B01")]
		[Address(RVA = "0x1D60420", Offset = "0x1D60420", VA = "0x7BBC560420")]
		public void SetData(TeammateStats info)
		{
		}

		// Token: 0x06007B02 RID: 31490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B02")]
		[Address(RVA = "0x1D605AC", Offset = "0x1D605AC", VA = "0x7BBC5605AC")]
		public void RefreshFriendBtnShow()
		{
		}

		// Token: 0x06007B03 RID: 31491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B03")]
		[Address(RVA = "0x1D606CC", Offset = "0x1D606CC", VA = "0x7BBC5606CC")]
		private void OnAddFriendClick()
		{
		}

		// Token: 0x06007B04 RID: 31492 RVA: 0x00021D98 File Offset: 0x0001FF98
		[Token(Token = "0x6007B04")]
		[Address(RVA = "0x1D608D4", Offset = "0x1D608D4", VA = "0x7BBC5608D4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007B05 RID: 31493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B05")]
		[Address(RVA = "0x1D60924", Offset = "0x1D60924", VA = "0x7BBC560924")]
		public UIHistoryTeammateController()
		{
		}

		// Token: 0x04008F8F RID: 36751
		[Token(Token = "0x4008F8F")]
		[FieldOffset(Offset = "0x58")]
		private UIBriefProfileInfoController m_CallSign;

		// Token: 0x04008F90 RID: 36752
		[Token(Token = "0x4008F90")]
		[FieldOffset(Offset = "0x60")]
		private UIHistoryTeammateView m_View;

		// Token: 0x04008F91 RID: 36753
		[Token(Token = "0x4008F91")]
		[FieldOffset(Offset = "0x68")]
		private BaseProfileInfo m_Info;
	}
}
