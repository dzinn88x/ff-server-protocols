using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200191C RID: 6428
	[Token(Token = "0x200191C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F58D4", Offset = "0x10F58D4")]
	internal class UIHudNameRedEnvelopeReceiverController : UIHudNameBaseController
	{
		// Token: 0x060081B2 RID: 33202 RVA: 0x000235B0 File Offset: 0x000217B0
		[Token(Token = "0x60081B2")]
		[Address(RVA = "0x17B7E60", Offset = "0x17B7E60", VA = "0x7BBBFB7E60")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060081B3 RID: 33203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081B3")]
		[Address(RVA = "0x17B7EB0", Offset = "0x17B7EB0", VA = "0x7BBBFB7EB0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060081B4 RID: 33204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081B4")]
		[Address(RVA = "0x17B7F10", Offset = "0x17B7F10", VA = "0x7BBBFB7F10")]
		public void BindPlayer(Player player, ulong ownerID, string ownerName, bool isLucky)
		{
		}

		// Token: 0x060081B5 RID: 33205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081B5")]
		[Address(RVA = "0x17B80E0", Offset = "0x17B80E0", VA = "0x7BBBFB80E0")]
		private void RemoveSelf()
		{
		}

		// Token: 0x060081B6 RID: 33206 RVA: 0x000235C8 File Offset: 0x000217C8
		[Token(Token = "0x60081B6")]
		[Address(RVA = "0x17B81EC", Offset = "0x17B81EC", VA = "0x7BBBFB81EC", Slot = "28")]
		protected override Vector3 TargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x060081B7 RID: 33207 RVA: 0x000235E0 File Offset: 0x000217E0
		[Token(Token = "0x60081B7")]
		[Address(RVA = "0x17B8340", Offset = "0x17B8340", VA = "0x7BBBFB8340", Slot = "29")]
		protected override bool NeedAutoScaleByDistance()
		{
			return default(bool);
		}

		// Token: 0x060081B8 RID: 33208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081B8")]
		[Address(RVA = "0x17B8348", Offset = "0x17B8348", VA = "0x7BBBFB8348")]
		public UIHudNameRedEnvelopeReceiverController()
		{
		}

		// Token: 0x0400934E RID: 37710
		[Token(Token = "0x400934E")]
		[FieldOffset(Offset = "0xA8")]
		private UIHudNameRedEnvelopeReceiverView m_View;

		// Token: 0x0400934F RID: 37711
		[Token(Token = "0x400934F")]
		[FieldOffset(Offset = "0xB0")]
		private Player m_Receiver;
	}
}
