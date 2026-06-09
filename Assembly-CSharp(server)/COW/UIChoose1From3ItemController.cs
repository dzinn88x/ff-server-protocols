using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200170E RID: 5902
	[Token(Token = "0x200170E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F15D4", Offset = "0x10F15D4")]
	public class UIChoose1From3ItemController : UIBaseController
	{
		// Token: 0x06006DFB RID: 28155 RVA: 0x0001EFA8 File Offset: 0x0001D1A8
		[Token(Token = "0x6006DFB")]
		[Address(RVA = "0x1BF4920", Offset = "0x1BF4920", VA = "0x7BBC3F4920")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006DFC RID: 28156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DFC")]
		[Address(RVA = "0x1BF4970", Offset = "0x1BF4970", VA = "0x7BBC3F4970", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006DFD RID: 28157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DFD")]
		[Address(RVA = "0x1BF358C", Offset = "0x1BF358C", VA = "0x7BBC3F358C")]
		public void SetData(OptionalBundleShowData data, bool hasRecharge, Action<OptionalBundleShowData> onClickItem)
		{
		}

		// Token: 0x06006DFE RID: 28158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DFE")]
		[Address(RVA = "0x1BF39DC", Offset = "0x1BF39DC", VA = "0x7BBC3F39DC")]
		public void ShowSelect(bool value)
		{
		}

		// Token: 0x06006DFF RID: 28159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DFF")]
		[Address(RVA = "0x1BF4AA4", Offset = "0x1BF4AA4", VA = "0x7BBC3F4AA4")]
		public void OnClickItem()
		{
		}

		// Token: 0x06006E00 RID: 28160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E00")]
		[Address(RVA = "0x1BF4A64", Offset = "0x1BF4A64", VA = "0x7BBC3F4A64")]
		public void SetQualityBG()
		{
		}

		// Token: 0x06006E01 RID: 28161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E01")]
		[Address(RVA = "0x1BF4B08", Offset = "0x1BF4B08", VA = "0x7BBC3F4B08")]
		public static void SetQualityBG(int Quality, UISprite QualityBG)
		{
		}

		// Token: 0x06006E02 RID: 28162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E02")]
		[Address(RVA = "0x1BF4C0C", Offset = "0x1BF4C0C", VA = "0x7BBC3F4C0C")]
		public UIChoose1From3ItemController()
		{
		}

		// Token: 0x040088CC RID: 35020
		[Token(Token = "0x40088CC")]
		[FieldOffset(Offset = "0x58")]
		private UIChoose1From3ItemView m_View;

		// Token: 0x040088CD RID: 35021
		[Token(Token = "0x40088CD")]
		[FieldOffset(Offset = "0x60")]
		private Action<OptionalBundleShowData> m_OnClickItem;

		// Token: 0x040088CE RID: 35022
		[Token(Token = "0x40088CE")]
		[FieldOffset(Offset = "0x68")]
		private OptionalBundleShowData m_Data;

		// Token: 0x040088CF RID: 35023
		[Token(Token = "0x40088CF")]
		[FieldOffset(Offset = "0x70")]
		private bool m_HasRecharge;

		// Token: 0x040088D0 RID: 35024
		[Token(Token = "0x40088D0")]
		[FieldOffset(Offset = "0x78")]
		private BaseItemInfo m_Info;
	}
}
