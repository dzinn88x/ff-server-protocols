using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A5A RID: 6746
	[Token(Token = "0x2001A5A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F800C", Offset = "0x10F800C")]
	public class UIManualWeaponController : UIManualContentBaseController, ITipsDelegate
	{
		// Token: 0x06008DF3 RID: 36339 RVA: 0x00025D88 File Offset: 0x00023F88
		[Token(Token = "0x6008DF3")]
		[Address(RVA = "0x18E7698", Offset = "0x18E7698", VA = "0x7BBC0E7698")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008DF4 RID: 36340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DF4")]
		[Address(RVA = "0x18E76E8", Offset = "0x18E76E8", VA = "0x7BBC0E76E8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008DF5 RID: 36341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DF5")]
		[Address(RVA = "0x18E822C", Offset = "0x18E822C", VA = "0x7BBC0E822C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008DF6 RID: 36342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DF6")]
		[Address(RVA = "0x18E8424", Offset = "0x18E8424", VA = "0x7BBC0E8424", Slot = "28")]
		public override void SetData(UIManualDataBase data)
		{
		}

		// Token: 0x06008DF7 RID: 36343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DF7")]
		[Address(RVA = "0x18E8984", Offset = "0x18E8984", VA = "0x7BBC0E8984", Slot = "29")]
		public override void ClearData()
		{
		}

		// Token: 0x06008DF8 RID: 36344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DF8")]
		[Address(RVA = "0x18E8AE4", Offset = "0x18E8AE4", VA = "0x7BBC0E8AE4", Slot = "30")]
		public override void RefreshView()
		{
		}

		// Token: 0x06008DF9 RID: 36345 RVA: 0x00025DA0 File Offset: 0x00023FA0
		[Token(Token = "0x6008DF9")]
		[Address(RVA = "0x18E93F8", Offset = "0x18E93F8", VA = "0x7BBC0E93F8", Slot = "31")]
		protected override int GetMaxPage()
		{
			return 0;
		}

		// Token: 0x06008DFA RID: 36346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DFA")]
		[Address(RVA = "0x18E8DF8", Offset = "0x18E8DF8", VA = "0x7BBC0E8DF8")]
		private void SetItems(int page, bool doDefaultSelect = true)
		{
		}

		// Token: 0x06008DFB RID: 36347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DFB")]
		[Address(RVA = "0x18E971C", Offset = "0x18E971C", VA = "0x7BBC0E971C")]
		public void OnSelectItem(ManualWeaponData data)
		{
		}

		// Token: 0x06008DFC RID: 36348 RVA: 0x00025DB8 File Offset: 0x00023FB8
		[Token(Token = "0x6008DFC")]
		[Address(RVA = "0x18E95F4", Offset = "0x18E95F4", VA = "0x7BBC0E95F4")]
		public bool HasUnlock(ManualWeaponData data)
		{
			return default(bool);
		}

		// Token: 0x06008DFD RID: 36349 RVA: 0x00025DD0 File Offset: 0x00023FD0
		[Token(Token = "0x6008DFD")]
		[Address(RVA = "0x18E96F4", Offset = "0x18E96F4", VA = "0x7BBC0E96F4")]
		public bool IsSelect(ManualWeaponData data)
		{
			return default(bool);
		}

		// Token: 0x06008DFE RID: 36350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DFE")]
		[Address(RVA = "0x18E9E2C", Offset = "0x18E9E2C", VA = "0x7BBC0E9E2C")]
		public void OnClickMore()
		{
		}

		// Token: 0x06008DFF RID: 36351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008DFF")]
		[Address(RVA = "0x18E9508", Offset = "0x18E9508", VA = "0x7BBC0E9508")]
		public ManualWeaponData GetDesc(uint tabId, int page, int location)
		{
			return null;
		}

		// Token: 0x06008E00 RID: 36352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E00")]
		[Address(RVA = "0x18E9E50", Offset = "0x18E9E50", VA = "0x7BBC0E9E50")]
		private void OnClickReward()
		{
		}

		// Token: 0x06008E01 RID: 36353 RVA: 0x00025DE8 File Offset: 0x00023FE8
		[Token(Token = "0x6008E01")]
		[Address(RVA = "0x18EA658", Offset = "0x18EA658", VA = "0x7BBC0EA658")]
		private uint GetCurPeriodNumber()
		{
			return 0U;
		}

		// Token: 0x06008E02 RID: 36354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008E02")]
		[Address(RVA = "0x18EA674", Offset = "0x18EA674", VA = "0x7BBC0EA674")]
		private ManualWeaponReward GetCurPeriodWeaponStatus()
		{
			return null;
		}

		// Token: 0x06008E03 RID: 36355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E03")]
		[Address(RVA = "0x18E8694", Offset = "0x18E8694", VA = "0x7BBC0E8694")]
		private void UpdateRewardView(params object[] parameters)
		{
		}

		// Token: 0x06008E04 RID: 36356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E04")]
		[Address(RVA = "0x18EA8F4", Offset = "0x18EA8F4", VA = "0x7BBC0EA8F4", Slot = "32")]
		public void OnTipsDataChange(ETipsType type, int num)
		{
		}

		// Token: 0x06008E05 RID: 36357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E05")]
		[Address(RVA = "0x18EAB54", Offset = "0x18EAB54", VA = "0x7BBC0EAB54")]
		public UIManualWeaponController()
		{
		}

		// Token: 0x06008E06 RID: 36358 RVA: 0x00025E00 File Offset: 0x00024000
		[Token(Token = "0x6008E06")]
		[Address(RVA = "0x18EAB5C", Offset = "0x18EAB5C", VA = "0x7BBC0EAB5C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11445F0", Offset = "0x11445F0")]
		private bool <SetData>b__15_1(ManualWeaponData temp)
		{
			return default(bool);
		}

		// Token: 0x040099BB RID: 39355
		[Token(Token = "0x40099BB")]
		[FieldOffset(Offset = "0x78")]
		private UIManualWeaponData m_UIManualWeaponData;

		// Token: 0x040099BC RID: 39356
		[Token(Token = "0x40099BC")]
		[FieldOffset(Offset = "0x80")]
		private UIManualWeaponView m_View;

		// Token: 0x040099BD RID: 39357
		[Token(Token = "0x40099BD")]
		[FieldOffset(Offset = "0x88")]
		private List<ManualWeaponData> m_Weapons;

		// Token: 0x040099BE RID: 39358
		[Token(Token = "0x40099BE")]
		[FieldOffset(Offset = "0x90")]
		private UIManualWeaponItemView[] m_Items;

		// Token: 0x040099BF RID: 39359
		[Token(Token = "0x40099BF")]
		[FieldOffset(Offset = "0x98")]
		private Transform[] m_ItemParents;

		// Token: 0x040099C0 RID: 39360
		[Token(Token = "0x40099C0")]
		[FieldOffset(Offset = "0xA0")]
		private UIButton[] m_Badges;

		// Token: 0x040099C1 RID: 39361
		[Token(Token = "0x40099C1")]
		[FieldOffset(Offset = "0xA8")]
		private ManualWeaponData m_CurSelectData;

		// Token: 0x040099C2 RID: 39362
		[Token(Token = "0x40099C2")]
		private const string REWARD_FORMAT = "{0}/{1}";

		// Token: 0x040099C3 RID: 39363
		[Token(Token = "0x40099C3")]
		[FieldOffset(Offset = "0xB0")]
		private Vector2 m_OriginSize;

		// Token: 0x040099C4 RID: 39364
		[Token(Token = "0x40099C4")]
		[FieldOffset(Offset = "0xB8")]
		private UIScrollView m_LabelScrollView;

		// Token: 0x040099C5 RID: 39365
		[Token(Token = "0x40099C5")]
		[FieldOffset(Offset = "0xC0")]
		private GameObject m_LeftArrowTips;

		// Token: 0x040099C6 RID: 39366
		[Token(Token = "0x40099C6")]
		[FieldOffset(Offset = "0xC8")]
		private GameObject m_RightArrowTips;

		// Token: 0x02001A5B RID: 6747
		[Token(Token = "0x2001A5B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F8044", Offset = "0x10F8044")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06008E08 RID: 36360 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008E08")]
			[Address(RVA = "0x18EAC0C", Offset = "0x18EAC0C", VA = "0x7BBC0EAC0C")]
			public <>c()
			{
			}

			// Token: 0x06008E09 RID: 36361 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6008E09")]
			[Address(RVA = "0x18EAC14", Offset = "0x18EAC14", VA = "0x7BBC0EAC14")]
			internal ManualWeaponData <SetData>b__15_0(CSVBaseData temp)
			{
				return null;
			}

			// Token: 0x06008E0A RID: 36362 RVA: 0x00025E18 File Offset: 0x00024018
			[Token(Token = "0x6008E0A")]
			[Address(RVA = "0x18EAC94", Offset = "0x18EAC94", VA = "0x7BBC0EAC94")]
			internal bool <OnClickReward>b__25_0(ManualWeaponReward temp)
			{
				return default(bool);
			}

			// Token: 0x06008E0B RID: 36363 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6008E0B")]
			[Address(RVA = "0x18EACC8", Offset = "0x18EACC8", VA = "0x7BBC0EACC8")]
			internal ManualWeaponRewardData <OnClickReward>b__25_1(CSVBaseData temp)
			{
				return null;
			}

			// Token: 0x06008E0C RID: 36364 RVA: 0x00025E30 File Offset: 0x00024030
			[Token(Token = "0x6008E0C")]
			[Address(RVA = "0x18EAD48", Offset = "0x18EAD48", VA = "0x7BBC0EAD48")]
			internal bool <GetCurPeriodWeaponStatus>b__27_0(ManualWeaponReward temp)
			{
				return default(bool);
			}

			// Token: 0x06008E0D RID: 36365 RVA: 0x00025E48 File Offset: 0x00024048
			[Token(Token = "0x6008E0D")]
			[Address(RVA = "0x18EAD7C", Offset = "0x18EAD7C", VA = "0x7BBC0EAD7C")]
			internal bool <GetCurPeriodWeaponStatus>b__27_1(ManualWeaponReward temp)
			{
				return default(bool);
			}

			// Token: 0x06008E0E RID: 36366 RVA: 0x00025E60 File Offset: 0x00024060
			[Token(Token = "0x6008E0E")]
			[Address(RVA = "0x18EADB0", Offset = "0x18EADB0", VA = "0x7BBC0EADB0")]
			internal bool <UpdateRewardView>b__28_0(ManualWeaponReward temp)
			{
				return default(bool);
			}

			// Token: 0x040099C7 RID: 39367
			[Token(Token = "0x40099C7")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIManualWeaponController.<>c <>9;

			// Token: 0x040099C8 RID: 39368
			[Token(Token = "0x40099C8")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<CSVBaseData, ManualWeaponData> <>9__15_0;

			// Token: 0x040099C9 RID: 39369
			[Token(Token = "0x40099C9")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<ManualWeaponReward> <>9__25_0;

			// Token: 0x040099CA RID: 39370
			[Token(Token = "0x40099CA")]
			[FieldOffset(Offset = "0x18")]
			public static Converter<CSVBaseData, ManualWeaponRewardData> <>9__25_1;

			// Token: 0x040099CB RID: 39371
			[Token(Token = "0x40099CB")]
			[FieldOffset(Offset = "0x20")]
			public static Predicate<ManualWeaponReward> <>9__27_0;

			// Token: 0x040099CC RID: 39372
			[Token(Token = "0x40099CC")]
			[FieldOffset(Offset = "0x28")]
			public static Predicate<ManualWeaponReward> <>9__27_1;

			// Token: 0x040099CD RID: 39373
			[Token(Token = "0x40099CD")]
			[FieldOffset(Offset = "0x30")]
			public static Predicate<ManualWeaponReward> <>9__28_0;
		}

		// Token: 0x02001A5C RID: 6748
		[Token(Token = "0x2001A5C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F8054", Offset = "0x10F8054")]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x06008E0F RID: 36367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008E0F")]
			[Address(RVA = "0x18E9500", Offset = "0x18E9500", VA = "0x7BBC0E9500")]
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x06008E10 RID: 36368 RVA: 0x00025E78 File Offset: 0x00024078
			[Token(Token = "0x6008E10")]
			[Address(RVA = "0x18EADE4", Offset = "0x18EADE4", VA = "0x7BBC0EADE4")]
			internal bool <GetMaxPage>b__0(ManualWeaponData temp)
			{
				return default(bool);
			}

			// Token: 0x040099CE RID: 39374
			[Token(Token = "0x40099CE")]
			[FieldOffset(Offset = "0x10")]
			public int i;
		}

		// Token: 0x02001A5D RID: 6749
		[Token(Token = "0x2001A5D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F8064", Offset = "0x10F8064")]
		private sealed class <>c__DisplayClass24_0
		{
			// Token: 0x06008E11 RID: 36369 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008E11")]
			[Address(RVA = "0x18E9E48", Offset = "0x18E9E48", VA = "0x7BBC0E9E48")]
			public <>c__DisplayClass24_0()
			{
			}

			// Token: 0x06008E12 RID: 36370 RVA: 0x00025E90 File Offset: 0x00024090
			[Token(Token = "0x6008E12")]
			[Address(RVA = "0x18EAE20", Offset = "0x18EAE20", VA = "0x7BBC0EAE20")]
			internal bool <GetDesc>b__0(ManualWeaponData temp)
			{
				return default(bool);
			}

			// Token: 0x040099CF RID: 39375
			[Token(Token = "0x40099CF")]
			[FieldOffset(Offset = "0x10")]
			public int page;

			// Token: 0x040099D0 RID: 39376
			[Token(Token = "0x40099D0")]
			[FieldOffset(Offset = "0x14")]
			public int location;
		}

		// Token: 0x02001A5E RID: 6750
		[Token(Token = "0x2001A5E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F8074", Offset = "0x10F8074")]
		private sealed class <>c__DisplayClass25_0
		{
			// Token: 0x06008E13 RID: 36371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008E13")]
			[Address(RVA = "0x18EA650", Offset = "0x18EA650", VA = "0x7BBC0EA650")]
			public <>c__DisplayClass25_0()
			{
			}

			// Token: 0x06008E14 RID: 36372 RVA: 0x00025EA8 File Offset: 0x000240A8
			[Token(Token = "0x6008E14")]
			[Address(RVA = "0x18EAE74", Offset = "0x18EAE74", VA = "0x7BBC0EAE74")]
			internal bool <OnClickReward>b__2(ManualWeaponRewardData temp)
			{
				return default(bool);
			}

			// Token: 0x040099D1 RID: 39377
			[Token(Token = "0x40099D1")]
			[FieldOffset(Offset = "0x10")]
			public ManualWeaponReward status;
		}
	}
}
