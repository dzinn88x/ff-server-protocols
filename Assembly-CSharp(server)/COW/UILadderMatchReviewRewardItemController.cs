using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001535 RID: 5429
	[Token(Token = "0x2001535")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE414", Offset = "0x10EE414")]
	public class UILadderMatchReviewRewardItemController : UIEasyListItemController
	{
		// Token: 0x06005DAD RID: 23981 RVA: 0x0001B318 File Offset: 0x00019518
		[Token(Token = "0x6005DAD")]
		[Address(RVA = "0x1E92178", Offset = "0x1E92178", VA = "0x7BBC692178")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005DAE RID: 23982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DAE")]
		[Address(RVA = "0x1E921C8", Offset = "0x1E921C8", VA = "0x7BBC6921C8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005DAF RID: 23983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DAF")]
		[Address(RVA = "0x1E92280", Offset = "0x1E92280", VA = "0x7BBC692280", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005DB0 RID: 23984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB0")]
		[Address(RVA = "0x1E92E44", Offset = "0x1E92E44", VA = "0x7BBC692E44")]
		private void InitTrans()
		{
		}

		// Token: 0x06005DB1 RID: 23985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB1")]
		[Address(RVA = "0x1E93090", Offset = "0x1E93090", VA = "0x7BBC693090")]
		public UILadderMatchReviewRewardItemController()
		{
		}

		// Token: 0x04007F62 RID: 32610
		[Token(Token = "0x4007F62")]
		[FieldOffset(Offset = "0x70")]
		private LadderMatchReviewRewardItemView m_View;

		// Token: 0x04007F63 RID: 32611
		[Token(Token = "0x4007F63")]
		[FieldOffset(Offset = "0x78")]
		private UIModelLadderMatch model;

		// Token: 0x04007F64 RID: 32612
		[Token(Token = "0x4007F64")]
		[FieldOffset(Offset = "0x80")]
		private List<UIStandardItemMiniController> levelitems;

		// Token: 0x04007F65 RID: 32613
		[Token(Token = "0x4007F65")]
		[FieldOffset(Offset = "0x88")]
		private List<UIStandardItemMiniController> seasonitems;
	}
}
