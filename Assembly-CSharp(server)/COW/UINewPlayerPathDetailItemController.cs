using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001A9F RID: 6815
	[Token(Token = "0x2001A9F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F870C", Offset = "0x10F870C")]
	public class UINewPlayerPathDetailItemController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06008F9D RID: 36765 RVA: 0x00026430 File Offset: 0x00024630
		[Token(Token = "0x6008F9D")]
		[Address(RVA = "0x1AF6488", Offset = "0x1AF6488", VA = "0x7BBC2F6488")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008F9E RID: 36766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F9E")]
		[Address(RVA = "0x1AF64D8", Offset = "0x1AF64D8", VA = "0x7BBC2F64D8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008F9F RID: 36767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F9F")]
		[Address(RVA = "0x1AF6778", Offset = "0x1AF6778", VA = "0x7BBC2F6778", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008FA0 RID: 36768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FA0")]
		[Address(RVA = "0x1AF6170", Offset = "0x1AF6170", VA = "0x7BBC2F6170")]
		public void SetData(ActivityInfo info, NewPlayerSevenDaysData conf, bool isSelected)
		{
		}

		// Token: 0x06008FA1 RID: 36769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FA1")]
		[Address(RVA = "0x1AF682C", Offset = "0x1AF682C", VA = "0x7BBC2F682C")]
		private void UpdateView()
		{
		}

		// Token: 0x06008FA2 RID: 36770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FA2")]
		[Address(RVA = "0x1AF6DC0", Offset = "0x1AF6DC0", VA = "0x7BBC2F6DC0")]
		private void OnClickSelect()
		{
		}

		// Token: 0x06008FA3 RID: 36771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FA3")]
		[Address(RVA = "0x1AF6E90", Offset = "0x1AF6E90", VA = "0x7BBC2F6E90")]
		public void OnClickGoto()
		{
		}

		// Token: 0x06008FA4 RID: 36772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FA4")]
		[Address(RVA = "0x1AF6F30", Offset = "0x1AF6F30", VA = "0x7BBC2F6F30")]
		public void OnClickClaim()
		{
		}

		// Token: 0x06008FA5 RID: 36773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FA5")]
		[Address(RVA = "0x1AF6FF4", Offset = "0x1AF6FF4", VA = "0x7BBC2F6FF4")]
		public void OnClickRewardBtn()
		{
		}

		// Token: 0x06008FA6 RID: 36774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FA6")]
		[Address(RVA = "0x1AF6BC0", Offset = "0x1AF6BC0", VA = "0x7BBC2F6BC0")]
		private void UpdateClaimState()
		{
		}

		// Token: 0x06008FA7 RID: 36775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FA7")]
		[Address(RVA = "0x1AF741C", Offset = "0x1AF741C", VA = "0x7BBC2F741C", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008FA8 RID: 36776 RVA: 0x00026448 File Offset: 0x00024648
		[Token(Token = "0x6008FA8")]
		[Address(RVA = "0x1AF75F8", Offset = "0x1AF75F8", VA = "0x7BBC2F75F8", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008FA9 RID: 36777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FA9")]
		[Address(RVA = "0x1AF763C", Offset = "0x1AF763C", VA = "0x7BBC2F763C")]
		public UINewPlayerPathDetailItemController()
		{
		}

		// Token: 0x04009BC0 RID: 39872
		[Token(Token = "0x4009BC0")]
		[FieldOffset(Offset = "0x58")]
		private UINewPlayerPathDetailItemView m_View;

		// Token: 0x04009BC1 RID: 39873
		[Token(Token = "0x4009BC1")]
		[FieldOffset(Offset = "0x60")]
		private ActivityInfo m_Info;

		// Token: 0x04009BC2 RID: 39874
		[Token(Token = "0x4009BC2")]
		[FieldOffset(Offset = "0x68")]
		private NewPlayerSevenDaysData m_Conf;

		// Token: 0x04009BC3 RID: 39875
		[Token(Token = "0x4009BC3")]
		[FieldOffset(Offset = "0x70")]
		private BaseItemInfo m_RewardInfo;

		// Token: 0x04009BC4 RID: 39876
		[Token(Token = "0x4009BC4")]
		[FieldOffset(Offset = "0x78")]
		private uint GREY_COLOR;
	}
}
