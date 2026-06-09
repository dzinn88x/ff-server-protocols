using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200198D RID: 6541
	[Token(Token = "0x200198D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F68AC", Offset = "0x10F68AC")]
	internal class UIHudVehicleJumpController : UIHudVehicleItemButtonController
	{
		// Token: 0x06008570 RID: 34160 RVA: 0x00024318 File Offset: 0x00022518
		[Token(Token = "0x6008570")]
		[Address(RVA = "0x15F023C", Offset = "0x15F023C", VA = "0x7BBBDF023C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008571 RID: 34161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008571")]
		[Address(RVA = "0x15F028C", Offset = "0x15F028C", VA = "0x7BBBDF028C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008572 RID: 34162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008572")]
		[Address(RVA = "0x15F03A8", Offset = "0x15F03A8", VA = "0x7BBBDF03A8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008573 RID: 34163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008573")]
		[Address(RVA = "0x15F0470", Offset = "0x15F0470", VA = "0x7BBBDF0470", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06008574 RID: 34164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008574")]
		[Address(RVA = "0x15F04B8", Offset = "0x15F04B8", VA = "0x7BBBDF04B8", Slot = "34")]
		protected override void OnPlayerGetOnVehicle(params object[] ps)
		{
		}

		// Token: 0x06008575 RID: 34165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008575")]
		[Address(RVA = "0x15F05D8", Offset = "0x15F05D8", VA = "0x7BBBDF05D8")]
		protected void OnPlayerGetOffVehicle(params object[] ps)
		{
		}

		// Token: 0x06008576 RID: 34166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008576")]
		[Address(RVA = "0x15F0720", Offset = "0x15F0720", VA = "0x7BBBDF0720")]
		private void Update()
		{
		}

		// Token: 0x06008577 RID: 34167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008577")]
		[Address(RVA = "0x15F0818", Offset = "0x15F0818", VA = "0x7BBBDF0818")]
		private void SetHightlight(bool highlight)
		{
		}

		// Token: 0x06008578 RID: 34168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008578")]
		[Address(RVA = "0x15F0838", Offset = "0x15F0838", VA = "0x7BBBDF0838")]
		public UIHudVehicleJumpController()
		{
		}

		// Token: 0x04009502 RID: 38146
		[Token(Token = "0x4009502")]
		[FieldOffset(Offset = "0x70")]
		private UIHudVehicleJumpView m_View;

		// Token: 0x04009503 RID: 38147
		[Token(Token = "0x4009503")]
		[FieldOffset(Offset = "0x78")]
		private bool m_IsHighlight;

		// Token: 0x04009504 RID: 38148
		[Token(Token = "0x4009504")]
		[FieldOffset(Offset = "0x80")]
		private Vehicle m_Vehicle;
	}
}
