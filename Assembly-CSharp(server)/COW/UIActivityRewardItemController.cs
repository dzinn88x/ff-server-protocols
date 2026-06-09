using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200169D RID: 5789
	[Token(Token = "0x200169D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F06F4", Offset = "0x10F06F4")]
	public class UIActivityRewardItemController : UIBaseController
	{
		// Token: 0x0600694D RID: 26957 RVA: 0x0001DCD0 File Offset: 0x0001BED0
		[Token(Token = "0x600694D")]
		[Address(RVA = "0x195A018", Offset = "0x195A018", VA = "0x7BBC15A018")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600694E RID: 26958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600694E")]
		[Address(RVA = "0x195A068", Offset = "0x195A068", VA = "0x7BBC15A068", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600694F RID: 26959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600694F")]
		[Address(RVA = "0x195A1A4", Offset = "0x195A1A4", VA = "0x7BBC15A1A4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006950 RID: 26960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006950")]
		[Address(RVA = "0x195A1AC", Offset = "0x195A1AC", VA = "0x7BBC15A1AC")]
		public void SetData(AwardDesc item, bool enableToggle = false)
		{
		}

		// Token: 0x06006951 RID: 26961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006951")]
		[Address(RVA = "0x195A338", Offset = "0x195A338", VA = "0x7BBC15A338")]
		private void OnClickToggleItem()
		{
		}

		// Token: 0x06006952 RID: 26962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006952")]
		[Address(RVA = "0x195A4A8", Offset = "0x195A4A8", VA = "0x7BBC15A4A8")]
		public void SetItemIndex(int index)
		{
		}

		// Token: 0x06006953 RID: 26963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006953")]
		[Address(RVA = "0x195A4B0", Offset = "0x195A4B0", VA = "0x7BBC15A4B0")]
		private void OnClickItem()
		{
		}

		// Token: 0x06006954 RID: 26964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006954")]
		[Address(RVA = "0x195A8E8", Offset = "0x195A8E8", VA = "0x7BBC15A8E8")]
		public UIActivityRewardItemController()
		{
		}

		// Token: 0x04008648 RID: 34376
		[Token(Token = "0x4008648")]
		[FieldOffset(Offset = "0x58")]
		private UIActivityRewardItemView m_View;

		// Token: 0x04008649 RID: 34377
		[Token(Token = "0x4008649")]
		[FieldOffset(Offset = "0x60")]
		private BaseItemInfo m_data;

		// Token: 0x0400864A RID: 34378
		[Token(Token = "0x400864A")]
		[FieldOffset(Offset = "0x68")]
		private bool enabledToggle;

		// Token: 0x0400864B RID: 34379
		[Token(Token = "0x400864B")]
		[FieldOffset(Offset = "0x6C")]
		private int m_index;
	}
}
