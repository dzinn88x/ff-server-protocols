using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020019D8 RID: 6616
	[Token(Token = "0x20019D8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F71BC", Offset = "0x10F71BC")]
	public class UILegendClothVaultColorController : UIBaseController
	{
		// Token: 0x06008861 RID: 34913 RVA: 0x00024B88 File Offset: 0x00022D88
		[Token(Token = "0x6008861")]
		[Address(RVA = "0x1E3C44C", Offset = "0x1E3C44C", VA = "0x7BBC63C44C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008862 RID: 34914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008862")]
		[Address(RVA = "0x1E3C49C", Offset = "0x1E3C49C", VA = "0x7BBC63C49C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008863 RID: 34915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008863")]
		[Address(RVA = "0x1E3C874", Offset = "0x1E3C874", VA = "0x7BBC63C874", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06008864 RID: 34916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008864")]
		[Address(RVA = "0x1E3C9E8", Offset = "0x1E3C9E8", VA = "0x7BBC63C9E8")]
		public void SetData(LegendClothData data, bool isInInvotory, bool unLock)
		{
		}

		// Token: 0x06008865 RID: 34917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008865")]
		[Address(RVA = "0x1E3CD78", Offset = "0x1E3CD78", VA = "0x7BBC63CD78")]
		private void SetUnlock(bool canClick)
		{
		}

		// Token: 0x06008866 RID: 34918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008866")]
		[Address(RVA = "0x1E3CF04", Offset = "0x1E3CF04", VA = "0x7BBC63CF04")]
		private void OnClickBtnPick()
		{
		}

		// Token: 0x06008867 RID: 34919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008867")]
		[Address(RVA = "0x1E3CE38", Offset = "0x1E3CE38", VA = "0x7BBC63CE38")]
		private void OnColorPick(params object[] data)
		{
		}

		// Token: 0x06008868 RID: 34920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008868")]
		[Address(RVA = "0x1E3D3A8", Offset = "0x1E3D3A8", VA = "0x7BBC63D3A8")]
		private void OnSlotPick(params object[] data)
		{
		}

		// Token: 0x06008869 RID: 34921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008869")]
		[Address(RVA = "0x1E3D2AC", Offset = "0x1E3D2AC", VA = "0x7BBC63D2AC")]
		private void RefreshSelectType(int level)
		{
		}

		// Token: 0x0600886A RID: 34922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600886A")]
		[Address(RVA = "0x1E3C79C", Offset = "0x1E3C79C", VA = "0x7BBC63C79C")]
		private void ChangeSlotArmState(params object[] data)
		{
		}

		// Token: 0x0600886B RID: 34923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600886B")]
		[Address(RVA = "0x1E3D430", Offset = "0x1E3D430", VA = "0x7BBC63D430")]
		public UILegendClothVaultColorController()
		{
		}

		// Token: 0x040096CE RID: 38606
		[Token(Token = "0x40096CE")]
		[FieldOffset(Offset = "0x58")]
		private UILegendClothVaultColorView m_View;

		// Token: 0x040096CF RID: 38607
		[Token(Token = "0x40096CF")]
		[FieldOffset(Offset = "0x60")]
		private int m_LegendLevel;

		// Token: 0x040096D0 RID: 38608
		[Token(Token = "0x40096D0")]
		[FieldOffset(Offset = "0x64")]
		private Color m_Color;

		// Token: 0x040096D1 RID: 38609
		[Token(Token = "0x40096D1")]
		[FieldOffset(Offset = "0x74")]
		private bool m_Unlock;

		// Token: 0x040096D2 RID: 38610
		[Token(Token = "0x40096D2")]
		[FieldOffset(Offset = "0x75")]
		private bool m_Armed;

		// Token: 0x040096D3 RID: 38611
		[Token(Token = "0x40096D3")]
		[FieldOffset(Offset = "0x76")]
		private bool m_IsInInvotory;

		// Token: 0x040096D4 RID: 38612
		[Token(Token = "0x40096D4")]
		[FieldOffset(Offset = "0x77")]
		private bool m_IsTypeBig;
	}
}
