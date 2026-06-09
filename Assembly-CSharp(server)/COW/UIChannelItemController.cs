using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;
using UnityEngine;

namespace COW
{
	// Token: 0x020016F3 RID: 5875
	[Token(Token = "0x20016F3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F11CC", Offset = "0x10F11CC")]
	public class UIChannelItemController : UIEasyListItemController, ITipsDelegate
	{
		// Token: 0x06006D0D RID: 27917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D0D")]
		[Address(RVA = "0x1BDEAC8", Offset = "0x1BDEAC8", VA = "0x7BBC3DEAC8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006D0E RID: 27918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D0E")]
		[Address(RVA = "0x1BDEBDC", Offset = "0x1BDEBDC", VA = "0x7BBC3DEBDC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006D0F RID: 27919 RVA: 0x0001EC30 File Offset: 0x0001CE30
		[Token(Token = "0x6006D0F")]
		[Address(RVA = "0x1BDEC80", Offset = "0x1BDEC80", VA = "0x7BBC3DEC80")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006D10 RID: 27920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D10")]
		[Address(RVA = "0x1BDECD0", Offset = "0x1BDECD0", VA = "0x7BBC3DECD0", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006D11 RID: 27921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D11")]
		[Address(RVA = "0x1BDF060", Offset = "0x1BDF060", VA = "0x7BBC3DF060")]
		public void RefreshUnreadTips()
		{
		}

		// Token: 0x06006D12 RID: 27922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D12")]
		[Address(RVA = "0x1BDF134", Offset = "0x1BDF134", VA = "0x7BBC3DF134", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06006D13 RID: 27923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D13")]
		[Address(RVA = "0x1BDF408", Offset = "0x1BDF408", VA = "0x7BBC3DF408", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06006D14 RID: 27924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D14")]
		[Address(RVA = "0x1BDF51C", Offset = "0x1BDF51C", VA = "0x7BBC3DF51C", Slot = "34")]
		private void OnTipsDataChange(ETipsType type, int num)
		{
		}

		// Token: 0x06006D15 RID: 27925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D15")]
		[Address(RVA = "0x1BDF520", Offset = "0x1BDF520", VA = "0x7BBC3DF520")]
		public UIChannelItemController()
		{
		}

		// Token: 0x04008873 RID: 34931
		[Token(Token = "0x4008873")]
		[FieldOffset(Offset = "0x70")]
		private UIChannelItemView m_View;

		// Token: 0x04008874 RID: 34932
		[Token(Token = "0x4008874")]
		[FieldOffset(Offset = "0x78")]
		private ChatChannelInfo m_Info;

		// Token: 0x04008875 RID: 34933
		[Token(Token = "0x4008875")]
		[FieldOffset(Offset = "0x80")]
		private ETipsType m_TipsType;

		// Token: 0x04008876 RID: 34934
		[Token(Token = "0x4008876")]
		[FieldOffset(Offset = "0x84")]
		private bool isSelect;

		// Token: 0x04008877 RID: 34935
		[Token(Token = "0x4008877")]
		[FieldOffset(Offset = "0x0")]
		public static Color32 UnseletColor;

		// Token: 0x04008878 RID: 34936
		[Token(Token = "0x4008878")]
		[FieldOffset(Offset = "0x4")]
		public static Color32 SelectColor;

		// Token: 0x04008879 RID: 34937
		[Token(Token = "0x4008879")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<EChannel.ChannelType, string> m_StrKeyDic;
	}
}
