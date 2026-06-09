using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020017E4 RID: 6116
	[Token(Token = "0x20017E4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2FD4", Offset = "0x10F2FD4")]
	public class UIGachaDrawResultItemController : UIBaseController
	{
		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06007650 RID: 30288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000953")]
		public CommonRewardItemInfo Info
		{
			[Token(Token = "0x6007650")]
			[Address(RVA = "0x2160180", Offset = "0x2160180", VA = "0x7BBC960180")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007651 RID: 30289 RVA: 0x00020CE8 File Offset: 0x0001EEE8
		[Token(Token = "0x6007651")]
		[Address(RVA = "0x2160188", Offset = "0x2160188", VA = "0x7BBC960188")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007652 RID: 30290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007652")]
		[Address(RVA = "0x21601D8", Offset = "0x21601D8", VA = "0x7BBC9601D8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007653 RID: 30291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007653")]
		[Address(RVA = "0x216023C", Offset = "0x216023C", VA = "0x7BBC96023C", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06007654 RID: 30292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007654")]
		[Address(RVA = "0x2160244", Offset = "0x2160244", VA = "0x7BBC960244", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007655 RID: 30293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007655")]
		[Address(RVA = "0x216024C", Offset = "0x216024C", VA = "0x7BBC96024C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007656 RID: 30294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007656")]
		[Address(RVA = "0x2160254", Offset = "0x2160254", VA = "0x7BBC960254")]
		public void DoFlowAnim()
		{
		}

		// Token: 0x06007657 RID: 30295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007657")]
		[Address(RVA = "0x2160298", Offset = "0x2160298", VA = "0x7BBC960298")]
		public void SetData(CommonRewardItemInfo info, int index)
		{
		}

		// Token: 0x06007658 RID: 30296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007658")]
		[Address(RVA = "0x21604A0", Offset = "0x21604A0", VA = "0x7BBC9604A0")]
		public void ShowGemView()
		{
		}

		// Token: 0x06007659 RID: 30297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007659")]
		[Address(RVA = "0x2160698", Offset = "0x2160698", VA = "0x7BBC960698")]
		public void ShowRewardView()
		{
		}

		// Token: 0x0600765A RID: 30298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600765A")]
		[Address(RVA = "0x21607F0", Offset = "0x21607F0", VA = "0x7BBC9607F0")]
		public void AdjustScale(float scale)
		{
		}

		// Token: 0x0600765B RID: 30299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600765B")]
		[Address(RVA = "0x2160938", Offset = "0x2160938", VA = "0x7BBC960938")]
		public UIGachaDrawResultItemController()
		{
		}

		// Token: 0x04008D38 RID: 36152
		[Token(Token = "0x4008D38")]
		[FieldOffset(Offset = "0x58")]
		private UIGachaDrawResultItemView m_View;

		// Token: 0x04008D39 RID: 36153
		[Token(Token = "0x4008D39")]
		[FieldOffset(Offset = "0x60")]
		private int m_Idx;

		// Token: 0x04008D3A RID: 36154
		[Token(Token = "0x4008D3A")]
		private const float m_FlowRangeY = 9f;

		// Token: 0x04008D3B RID: 36155
		[Token(Token = "0x4008D3B")]
		[FieldOffset(Offset = "0x68")]
		private CommonRewardItemInfo m_Info;
	}
}
