using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001AE1 RID: 6881
	[Token(Token = "0x2001AE1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8D44", Offset = "0x10F8D44")]
	public class UIPaymentTotalItemController : UIBaseController
	{
		// Token: 0x060091CF RID: 37327 RVA: 0x00026D18 File Offset: 0x00024F18
		[Token(Token = "0x60091CF")]
		[Address(RVA = "0x1F39B88", Offset = "0x1F39B88", VA = "0x7BBC739B88")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060091D0 RID: 37328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091D0")]
		[Address(RVA = "0x1F39BD8", Offset = "0x1F39BD8", VA = "0x7BBC739BD8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060091D1 RID: 37329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091D1")]
		[Address(RVA = "0x1F39CBC", Offset = "0x1F39CBC", VA = "0x7BBC739CBC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060091D2 RID: 37330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091D2")]
		[Address(RVA = "0x1F38948", Offset = "0x1F38948", VA = "0x7BBC738948")]
		public void SetData(ClientActivityDesc desc)
		{
		}

		// Token: 0x060091D3 RID: 37331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091D3")]
		[Address(RVA = "0x1F39E24", Offset = "0x1F39E24", VA = "0x7BBC739E24")]
		private void OnGetRewardClick()
		{
		}

		// Token: 0x060091D4 RID: 37332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091D4")]
		[Address(RVA = "0x1F39CC4", Offset = "0x1F39CC4", VA = "0x7BBC739CC4")]
		private void UpdateBtnOperateStatus()
		{
		}

		// Token: 0x060091D5 RID: 37333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091D5")]
		[Address(RVA = "0x1F39F38", Offset = "0x1F39F38", VA = "0x7BBC739F38")]
		public UIPaymentTotalItemController()
		{
		}

		// Token: 0x04009CA6 RID: 40102
		[Token(Token = "0x4009CA6")]
		[FieldOffset(Offset = "0x58")]
		private UIPaymentTotalItemView m_View;

		// Token: 0x04009CA7 RID: 40103
		[Token(Token = "0x4009CA7")]
		[FieldOffset(Offset = "0x60")]
		private UIPaymentTotalItemController.BtnOperateType m_curOperation;

		// Token: 0x04009CA8 RID: 40104
		[Token(Token = "0x4009CA8")]
		[FieldOffset(Offset = "0x68")]
		private ClientActivityDesc m_Data;

		// Token: 0x04009CA9 RID: 40105
		[Token(Token = "0x4009CA9")]
		[FieldOffset(Offset = "0x70")]
		private List<UIPaymentTotalContentItemController> m_ContentItems;

		// Token: 0x02001AE2 RID: 6882
		[Token(Token = "0x2001AE2")]
		private enum BtnOperateType
		{
			// Token: 0x04009CAB RID: 40107
			[Token(Token = "0x4009CAB")]
			GetReward,
			// Token: 0x04009CAC RID: 40108
			[Token(Token = "0x4009CAC")]
			RewardFinished,
			// Token: 0x04009CAD RID: 40109
			[Token(Token = "0x4009CAD")]
			RewardUnfinish,
			// Token: 0x04009CAE RID: 40110
			[Token(Token = "0x4009CAE")]
			Forcast
		}
	}
}
