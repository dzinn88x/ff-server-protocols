using System;
using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001279 RID: 4729
	[Token(Token = "0x2001279")]
	public class AutoPickUpHelper
	{
		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06004934 RID: 18740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700083B")]
		private \u0080uwjcYk m_InventoryManager
		{
			[Token(Token = "0x6004934")]
			[Address(RVA = "0x1553A28", Offset = "0x1553A28", VA = "0x7BBBD53A28")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004935 RID: 18741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004935")]
		[Address(RVA = "0x1553B38", Offset = "0x1553B38", VA = "0x7BBBD53B38")]
		public AutoPickUpHelper()
		{
		}

		// Token: 0x06004936 RID: 18742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004936")]
		[Address(RVA = "0x1553C34", Offset = "0x1553C34", VA = "0x7BBBD53C34")]
		public void StartAutoPickup()
		{
		}

		// Token: 0x06004937 RID: 18743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004937")]
		[Address(RVA = "0x155434C", Offset = "0x155434C", VA = "0x7BBBD5434C")]
		public void StopAutoPickup(bool changedBySetting = false)
		{
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004938")]
		[Address(RVA = "0x1554890", Offset = "0x1554890", VA = "0x7BBBD54890")]
		private void DoAutoPickUp()
		{
		}

		// Token: 0x06004939 RID: 18745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004939")]
		[Address(RVA = "0x1554BA0", Offset = "0x1554BA0", VA = "0x7BBBD54BA0")]
		private void SortAutoPickQueue()
		{
		}

		// Token: 0x0600493A RID: 18746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600493A")]
		[Address(RVA = "0x1554D14", Offset = "0x1554D14", VA = "0x7BBBD54D14")]
		public void SetPickUpList(List<^yE\u007FRJO> pickupList)
		{
		}

		// Token: 0x0600493B RID: 18747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600493B")]
		[Address(RVA = "0x15544E4", Offset = "0x15544E4", VA = "0x7BBBD544E4")]
		public void RefreshAutoPickUpList()
		{
		}

		// Token: 0x0600493C RID: 18748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600493C")]
		[Address(RVA = "0x1554E5C", Offset = "0x1554E5C", VA = "0x7BBBD54E5C")]
		public void FreezeAutoPickup()
		{
		}

		// Token: 0x0600493D RID: 18749 RVA: 0x000162F0 File Offset: 0x000144F0
		[Token(Token = "0x600493D")]
		[Address(RVA = "0x1553E54", Offset = "0x1553E54", VA = "0x7BBBD53E54")]
		public static bool EnableAutoPickupFunction()
		{
			return default(bool);
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600493E")]
		[Address(RVA = "0x1554DA0", Offset = "0x1554DA0", VA = "0x7BBBD54DA0")]
		public void SortPickupList(List<^yE\u007FRJO> pickUps)
		{
		}

		// Token: 0x0600493F RID: 18751 RVA: 0x00016308 File Offset: 0x00014508
		[Token(Token = "0x600493F")]
		[Address(RVA = "0x1555064", Offset = "0x1555064", VA = "0x7BBBD55064")]
		public int AutoPickupSort(^yE\u007FRJO x, ^yE\u007FRJO y)
		{
			return 0;
		}

		// Token: 0x06004940 RID: 18752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004940")]
		[Address(RVA = "0x155546C", Offset = "0x155546C", VA = "0x7BBBD5546C")]
		public static List<AutoPickupConfigData> GetAutoPickUpConfigDataList()
		{
			return null;
		}

		// Token: 0x06004941 RID: 18753 RVA: 0x00016320 File Offset: 0x00014520
		[Token(Token = "0x6004941")]
		[Address(RVA = "0x155408C", Offset = "0x155408C", VA = "0x7BBBD5408C")]
		public static bool GetAutoPickupSettingByType(int itemType, int itemSubType)
		{
			return default(bool);
		}

		// Token: 0x06004942 RID: 18754 RVA: 0x00016338 File Offset: 0x00014538
		[Token(Token = "0x6004942")]
		[Address(RVA = "0x1555738", Offset = "0x1555738", VA = "0x7BBBD55738")]
		public static bool InitAutoPickUpKeyMap(bool forceRefresh = false)
		{
			return default(bool);
		}

		// Token: 0x06004944 RID: 18756 RVA: 0x00016350 File Offset: 0x00014550
		[Token(Token = "0x6004944")]
		[Address(RVA = "0x1555A18", Offset = "0x1555A18", VA = "0x7BBBD55A18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DC50", Offset = "0x113DC50")]
		private int <SortAutoPickQueue>b__14_0(^yE\u007FRJO a, ^yE\u007FRJO b)
		{
			return 0;
		}

		// Token: 0x0400721F RID: 29215
		[Token(Token = "0x400721F")]
		[FieldOffset(Offset = "0x10")]
		private Queue<^yE\u007FRJO> m_AutoPickupQueue;

		// Token: 0x04007220 RID: 29216
		[Token(Token = "0x4007220")]
		[FieldOffset(Offset = "0x18")]
		private List<^yE\u007FRJO> m_PickupInContainer;

		// Token: 0x04007221 RID: 29217
		[Token(Token = "0x4007221")]
		[FieldOffset(Offset = "0x20")]
		private uint m_AutoPickupDelayCall;

		// Token: 0x04007222 RID: 29218
		[Token(Token = "0x4007222")]
		[FieldOffset(Offset = "0x0")]
		private static bool pauseAutoPickup;

		// Token: 0x04007223 RID: 29219
		[Token(Token = "0x4007223")]
		[FieldOffset(Offset = "0x28")]
		private Player m_LocalPlayer;

		// Token: 0x04007224 RID: 29220
		[Token(Token = "0x4007224")]
		[FieldOffset(Offset = "0x30")]
		public BountyPickupStatus m_BountyStatus;

		// Token: 0x04007225 RID: 29221
		[Token(Token = "0x4007225")]
		[FieldOffset(Offset = "0x8")]
		private static List<AutoPickupConfigData> m_AutoPickConfigList;

		// Token: 0x04007226 RID: 29222
		[Token(Token = "0x4007226")]
		[FieldOffset(Offset = "0x10")]
		private static bool hasInit;

		// Token: 0x0200127A RID: 4730
		[Token(Token = "0x200127A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB010", Offset = "0x10EB010")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004946 RID: 18758 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004946")]
			[Address(RVA = "0x1555AF4", Offset = "0x1555AF4", VA = "0x7BBBD55AF4")]
			public <>c()
			{
			}

			// Token: 0x06004947 RID: 18759 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004947")]
			[Address(RVA = "0x1555AFC", Offset = "0x1555AFC", VA = "0x7BBBD55AFC")]
			internal void <FreezeAutoPickup>b__17_0()
			{
			}

			// Token: 0x04007227 RID: 29223
			[Token(Token = "0x4007227")]
			[FieldOffset(Offset = "0x0")]
			public static readonly AutoPickUpHelper.<>c <>9;

			// Token: 0x04007228 RID: 29224
			[Token(Token = "0x4007228")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__17_0;
		}
	}
}
