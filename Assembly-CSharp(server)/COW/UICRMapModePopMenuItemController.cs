using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200177A RID: 6010
	[Token(Token = "0x200177A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F21CC", Offset = "0x10F21CC")]
	public class UICRMapModePopMenuItemController : UIPopMenuItemBaseController
	{
		// Token: 0x060071DD RID: 29149 RVA: 0x0001FB18 File Offset: 0x0001DD18
		[Token(Token = "0x60071DD")]
		[Address(RVA = "0x1C21680", Offset = "0x1C21680", VA = "0x7BBC421680")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060071DE RID: 29150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071DE")]
		[Address(RVA = "0x1C216D0", Offset = "0x1C216D0", VA = "0x7BBC4216D0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060071DF RID: 29151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071DF")]
		[Address(RVA = "0x1C217B4", Offset = "0x1C217B4", VA = "0x7BBC4217B4", Slot = "30")]
		public override void SetItemData(PopMenuData data, int CellWidth, int CellHeight, float itemLocalPositionX, NGUIText.Alignment labelAlignment, UIWidget.Pivot labelPivot)
		{
		}

		// Token: 0x060071E0 RID: 29152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071E0")]
		[Address(RVA = "0x1C219D8", Offset = "0x1C219D8", VA = "0x7BBC4219D8")]
		private void SetSelectedState(bool selected)
		{
		}

		// Token: 0x060071E1 RID: 29153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071E1")]
		[Address(RVA = "0x1C21AF0", Offset = "0x1C21AF0", VA = "0x7BBC421AF0")]
		private void SetDownloadState(object data)
		{
		}

		// Token: 0x060071E2 RID: 29154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071E2")]
		[Address(RVA = "0x1C21D78", Offset = "0x1C21D78", VA = "0x7BBC421D78")]
		private void OnPopMenuItemClick()
		{
		}

		// Token: 0x060071E3 RID: 29155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071E3")]
		[Address(RVA = "0x1C21E80", Offset = "0x1C21E80", VA = "0x7BBC421E80")]
		public UICRMapModePopMenuItemController()
		{
		}

		// Token: 0x04008B30 RID: 35632
		[Token(Token = "0x4008B30")]
		[FieldOffset(Offset = "0x60")]
		private UICRMapModePopMenuItemView m_View;

		// Token: 0x04008B31 RID: 35633
		[Token(Token = "0x4008B31")]
		[FieldOffset(Offset = "0x68")]
		private PopMenuData m_Data;
	}
}
