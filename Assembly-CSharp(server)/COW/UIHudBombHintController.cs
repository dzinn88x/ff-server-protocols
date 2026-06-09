using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001881 RID: 6273
	[Token(Token = "0x2001881")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4354", Offset = "0x10F4354")]
	internal class UIHudBombHintController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06007C04 RID: 31748 RVA: 0x00022140 File Offset: 0x00020340
		[Token(Token = "0x6007C04")]
		[Address(RVA = "0x1898DBC", Offset = "0x1898DBC", VA = "0x7BBC098DBC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007C05 RID: 31749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C05")]
		[Address(RVA = "0x1898E0C", Offset = "0x1898E0C", VA = "0x7BBC098E0C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007C06 RID: 31750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C06")]
		[Address(RVA = "0x1898F74", Offset = "0x1898F74", VA = "0x7BBC098F74", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007C07 RID: 31751 RVA: 0x00022158 File Offset: 0x00020358
		[Token(Token = "0x6007C07")]
		[Address(RVA = "0x1899060", Offset = "0x1899060", VA = "0x7BBC099060", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007C08 RID: 31752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C08")]
		[Address(RVA = "0x18990A4", Offset = "0x18990A4", VA = "0x7BBC0990A4", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007C09 RID: 31753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C09")]
		[Address(RVA = "0x18996CC", Offset = "0x18996CC", VA = "0x7BBC0996CC")]
		private void UpdateHintInfo(BombModeNotification notification, bool needAutoHide = true)
		{
		}

		// Token: 0x06007C0A RID: 31754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C0A")]
		[Address(RVA = "0x1899A6C", Offset = "0x1899A6C", VA = "0x7BBC099A6C")]
		private void On3PPreparation(params object[] data)
		{
		}

		// Token: 0x06007C0B RID: 31755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C0B")]
		[Address(RVA = "0x1899DE0", Offset = "0x1899DE0", VA = "0x7BBC099DE0")]
		public UIHudBombHintController()
		{
		}

		// Token: 0x0400903B RID: 36923
		[Token(Token = "0x400903B")]
		[FieldOffset(Offset = "0x58")]
		private UIModelMatch m_MatchModel;

		// Token: 0x0400903C RID: 36924
		[Token(Token = "0x400903C")]
		[FieldOffset(Offset = "0x60")]
		private UIHudBombHintView m_View;

		// Token: 0x0400903D RID: 36925
		[Token(Token = "0x400903D")]
		[FieldOffset(Offset = "0x68")]
		public Color iconTintWhiteColor;

		// Token: 0x0400903E RID: 36926
		[Token(Token = "0x400903E")]
		[FieldOffset(Offset = "0x78")]
		public Color iconTintYellowColor;

		// Token: 0x0400903F RID: 36927
		[Token(Token = "0x400903F")]
		[FieldOffset(Offset = "0x88")]
		private uint m_DelayCall;
	}
}
