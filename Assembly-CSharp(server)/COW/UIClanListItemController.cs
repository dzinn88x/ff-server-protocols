using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001728 RID: 5928
	[Token(Token = "0x2001728")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1984", Offset = "0x10F1984")]
	public class UIClanListItemController : UIEasyListItemController
	{
		// Token: 0x06006EC7 RID: 28359 RVA: 0x0001F290 File Offset: 0x0001D490
		[Token(Token = "0x6006EC7")]
		[Address(RVA = "0x1CFBB0C", Offset = "0x1CFBB0C", VA = "0x7BBC4FBB0C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006EC8 RID: 28360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC8")]
		[Address(RVA = "0x1CFBB5C", Offset = "0x1CFBB5C", VA = "0x7BBC4FBB5C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006EC9 RID: 28361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC9")]
		[Address(RVA = "0x1CFBC40", Offset = "0x1CFBC40", VA = "0x7BBC4FBC40", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006ECA RID: 28362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ECA")]
		[Address(RVA = "0x1CFC3A8", Offset = "0x1CFC3A8", VA = "0x7BBC4FC3A8")]
		public void ChangeLabelType(EClanSearchLabelType type)
		{
		}

		// Token: 0x06006ECB RID: 28363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ECB")]
		[Address(RVA = "0x1CFC798", Offset = "0x1CFC798", VA = "0x7BBC4FC798")]
		public void OnBtnClanJoin()
		{
		}

		// Token: 0x06006ECC RID: 28364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ECC")]
		[Address(RVA = "0x1CFC620", Offset = "0x1CFC620", VA = "0x7BBC4FC620")]
		public void UpdateRank(int rank)
		{
		}

		// Token: 0x06006ECD RID: 28365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ECD")]
		[Address(RVA = "0x1CFCC00", Offset = "0x1CFCC00", VA = "0x7BBC4FCC00")]
		public UIClanListItemController()
		{
		}

		// Token: 0x04008933 RID: 35123
		[Token(Token = "0x4008933")]
		[FieldOffset(Offset = "0x70")]
		private UIClanListItemView m_View;

		// Token: 0x04008934 RID: 35124
		[Token(Token = "0x4008934")]
		[FieldOffset(Offset = "0x78")]
		private ClanInfo m_ClanInfo;

		// Token: 0x04008935 RID: 35125
		[Token(Token = "0x4008935")]
		[FieldOffset(Offset = "0x80")]
		private EClanSearchLabelType m_SearchLabelType;
	}
}
