using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020013B5 RID: 5045
	[Token(Token = "0x20013B5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBB90", Offset = "0x10EBB90")]
	public class UISuperCarDailyItemController : UIBaseController
	{
		// Token: 0x06005236 RID: 21046 RVA: 0x00018B70 File Offset: 0x00016D70
		[Token(Token = "0x6005236")]
		[Address(RVA = "0x2141FF4", Offset = "0x2141FF4", VA = "0x7BBC941FF4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005237 RID: 21047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005237")]
		[Address(RVA = "0x2142044", Offset = "0x2142044", VA = "0x7BBC942044", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005238 RID: 21048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005238")]
		[Address(RVA = "0x21421B4", Offset = "0x21421B4", VA = "0x7BBC9421B4", Slot = "28")]
		protected virtual object CreateView()
		{
			return null;
		}

		// Token: 0x06005239 RID: 21049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005239")]
		[Address(RVA = "0x2142204", Offset = "0x2142204", VA = "0x7BBC942204")]
		public void SetData(ClientActivityDesc desc)
		{
		}

		// Token: 0x0600523A RID: 21050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600523A")]
		[Address(RVA = "0x214258C", Offset = "0x214258C", VA = "0x7BBC94258C")]
		public void RefreshData()
		{
		}

		// Token: 0x0600523B RID: 21051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600523B")]
		[Address(RVA = "0x2142688", Offset = "0x2142688", VA = "0x7BBC942688")]
		private void SetOperateButtonUI()
		{
		}

		// Token: 0x0600523C RID: 21052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600523C")]
		[Address(RVA = "0x2142290", Offset = "0x2142290", VA = "0x7BBC942290")]
		private void CreateAwardItems(List<AwardDesc> awards)
		{
		}

		// Token: 0x0600523D RID: 21053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600523D")]
		[Address(RVA = "0x2142C64", Offset = "0x2142C64", VA = "0x7BBC942C64")]
		private void OnOperate()
		{
		}

		// Token: 0x0600523E RID: 21054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600523E")]
		[Address(RVA = "0x2142D44", Offset = "0x2142D44", VA = "0x7BBC942D44")]
		public UISuperCarDailyItemController()
		{
		}

		// Token: 0x04007848 RID: 30792
		[Token(Token = "0x4007848")]
		[FieldOffset(Offset = "0x58")]
		private UISuperCarDailyItemView m_View;

		// Token: 0x04007849 RID: 30793
		[Token(Token = "0x4007849")]
		[FieldOffset(Offset = "0x60")]
		private UISuperCarDailyItemController.OperateStatus m_OperateStatus;

		// Token: 0x0400784A RID: 30794
		[Token(Token = "0x400784A")]
		[FieldOffset(Offset = "0x68")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x0400784B RID: 30795
		[Token(Token = "0x400784B")]
		[FieldOffset(Offset = "0x70")]
		private ClientActivityDesc m_Desc;

		// Token: 0x020013B6 RID: 5046
		[Token(Token = "0x20013B6")]
		private enum OperateStatus
		{
			// Token: 0x0400784D RID: 30797
			[Token(Token = "0x400784D")]
			None,
			// Token: 0x0400784E RID: 30798
			[Token(Token = "0x400784E")]
			Exchange,
			// Token: 0x0400784F RID: 30799
			[Token(Token = "0x400784F")]
			ExchangeNo,
			// Token: 0x04007850 RID: 30800
			[Token(Token = "0x4007850")]
			ExchangeFinished
		}
	}
}
