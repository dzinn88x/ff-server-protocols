using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001542 RID: 5442
	[Token(Token = "0x2001542")]
	public abstract class UILinkActivityDetailController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06005DFD RID: 24061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DFD")]
		[Address(RVA = "0x1CB9D00", Offset = "0x1CB9D00", VA = "0x7BBC4B9D00", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005DFE RID: 24062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DFE")]
		[Address(RVA = "0x1CB9DDC", Offset = "0x1CB9DDC", VA = "0x7BBC4B9DDC", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06005DFF RID: 24063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DFF")]
		[Address(RVA = "0x1CB9E84", Offset = "0x1CB9E84", VA = "0x7BBC4B9E84", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005E00 RID: 24064 RVA: 0x0001B468 File Offset: 0x00019668
		[Token(Token = "0x6005E00")]
		[Address(RVA = "0x1CB9EC4", Offset = "0x1CB9EC4", VA = "0x7BBC4B9EC4", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005E01 RID: 24065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E01")]
		[Address(RVA = "0x1CB9ECC", Offset = "0x1CB9ECC", VA = "0x7BBC4B9ECC", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005E02 RID: 24066
		[Token(Token = "0x6005E02")]
		protected abstract void InitActivityInfo();

		// Token: 0x06005E03 RID: 24067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E03")]
		[Address(RVA = "0x1CB9FF4", Offset = "0x1CB9FF4", VA = "0x7BBC4B9FF4")]
		protected void InitDaysLabel(UILabel days)
		{
		}

		// Token: 0x06005E04 RID: 24068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E04")]
		[Address(RVA = "0x1CBA0F4", Offset = "0x1CBA0F4", VA = "0x7BBC4BA0F4")]
		protected void InitDaysLabel(UILabel curDay, UILabel totalDay)
		{
		}

		// Token: 0x06005E05 RID: 24069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E05")]
		[Address(RVA = "0x1CBA210", Offset = "0x1CBA210", VA = "0x7BBC4BA210")]
		protected void InitFinishCountLabel(UILabel label)
		{
		}

		// Token: 0x06005E06 RID: 24070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E06")]
		[Address(RVA = "0x1CBA354", Offset = "0x1CBA354", VA = "0x7BBC4BA354")]
		public void InitFinishCountLabel(UILabel current, UILabel total)
		{
		}

		// Token: 0x06005E07 RID: 24071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E07")]
		[Address(RVA = "0x1CBA464", Offset = "0x1CBA464", VA = "0x7BBC4BA464")]
		protected void InitFinishCountProgress(UIProgressBar bar)
		{
		}

		// Token: 0x06005E08 RID: 24072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E08")]
		[Address(RVA = "0x1CBA568", Offset = "0x1CBA568", VA = "0x7BBC4BA568")]
		protected void InitCdnTexture(UINetworkTexture tex, Action<Texture> callback)
		{
		}

		// Token: 0x06005E09 RID: 24073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E09")]
		protected void InitDailyRewards<T>(UIGrid grid, ref List<T> ctrls, int maxCount = 4) where T : UIBaseController, ISetBaseItemInfo
		{
		}

		// Token: 0x06005E0A RID: 24074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E0A")]
		[Address(RVA = "0x1CBA694", Offset = "0x1CBA694", VA = "0x7BBC4BA694")]
		protected void InitBigRewardIcon(UISprite icon)
		{
		}

		// Token: 0x06005E0B RID: 24075 RVA: 0x0001B480 File Offset: 0x00019680
		[Token(Token = "0x6005E0B")]
		[Address(RVA = "0x1CBA77C", Offset = "0x1CBA77C", VA = "0x7BBC4BA77C")]
		protected bool SetIconByItemId(UISprite icon, uint id)
		{
			return default(bool);
		}

		// Token: 0x06005E0C RID: 24076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E0C")]
		[Address(RVA = "0x1CBA8E0", Offset = "0x1CBA8E0", VA = "0x7BBC4BA8E0", Slot = "31")]
		protected virtual void OnGotReward(AwardData award)
		{
		}

		// Token: 0x06005E0D RID: 24077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E0D")]
		[Address(RVA = "0x1CBAB68", Offset = "0x1CBAB68", VA = "0x7BBC4BAB68")]
		protected void InitCloseBtn(UIButton btn)
		{
		}

		// Token: 0x06005E0E RID: 24078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E0E")]
		[Address(RVA = "0x1CBAC1C", Offset = "0x1CBAC1C", VA = "0x7BBC4BAC1C", Slot = "32")]
		protected virtual void InitGotoBtn(UIButton btn)
		{
		}

		// Token: 0x06005E0F RID: 24079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E0F")]
		[Address(RVA = "0x1CBAD28", Offset = "0x1CBAD28", VA = "0x7BBC4BAD28")]
		protected void InitLinkBtn(UIButton btn)
		{
		}

		// Token: 0x06005E10 RID: 24080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E10")]
		[Address(RVA = "0x1CBADDC", Offset = "0x1CBADDC", VA = "0x7BBC4BADDC")]
		protected void InitClaimBtn(UIButton btn, Transform parent)
		{
		}

		// Token: 0x06005E11 RID: 24081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E11")]
		[Address(RVA = "0x1CBAEE0", Offset = "0x1CBAEE0", VA = "0x7BBC4BAEE0")]
		protected void ShowTooltip(Transform tr, uint itemId)
		{
		}

		// Token: 0x06005E12 RID: 24082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E12")]
		[Address(RVA = "0x1CBAF94", Offset = "0x1CBAF94", VA = "0x7BBC4BAF94")]
		protected void ShowTooltip(Transform tr, string nameKey, string descKey)
		{
		}

		// Token: 0x06005E13 RID: 24083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E13")]
		[Address(RVA = "0x1CBB13C", Offset = "0x1CBB13C", VA = "0x7BBC4BB13C")]
		protected void InitEndTime(UICountDownLabel timeLabel)
		{
		}

		// Token: 0x06005E14 RID: 24084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E14")]
		[Address(RVA = "0x1CBB228", Offset = "0x1CBB228", VA = "0x7BBC4BB228")]
		protected UILinkActivityDetailController()
		{
		}

		// Token: 0x06005E15 RID: 24085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E15")]
		[Address(RVA = "0x1CBB23C", Offset = "0x1CBB23C", VA = "0x7BBC4BB23C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FB0C", Offset = "0x113FB0C")]
		private void <InitLinkBtn>b__21_0()
		{
		}

		// Token: 0x04007F84 RID: 32644
		[Token(Token = "0x4007F84")]
		[FieldOffset(Offset = "0x58")]
		protected UIModelLinkActivity m_Model;

		// Token: 0x04007F85 RID: 32645
		[Token(Token = "0x4007F85")]
		[FieldOffset(Offset = "0x60")]
		protected LinkActivityData m_ActivityData;

		// Token: 0x04007F86 RID: 32646
		[Token(Token = "0x4007F86")]
		[FieldOffset(Offset = "0x68")]
		protected float RewardedIconColorVal;

		// Token: 0x02001543 RID: 5443
		[Token(Token = "0x2001543")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EE55C", Offset = "0x10EE55C")]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x06005E16 RID: 24086 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E16")]
			[Address(RVA = "0x1CBA68C", Offset = "0x1CBA68C", VA = "0x7BBC4BA68C")]
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x06005E17 RID: 24087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E17")]
			[Address(RVA = "0x1CBB438", Offset = "0x1CBB438", VA = "0x7BBC4BB438")]
			internal void <InitCdnTexture>b__0()
			{
			}

			// Token: 0x04007F87 RID: 32647
			[Token(Token = "0x4007F87")]
			[FieldOffset(Offset = "0x10")]
			public Action<Texture> callback;

			// Token: 0x04007F88 RID: 32648
			[Token(Token = "0x4007F88")]
			[FieldOffset(Offset = "0x18")]
			public UINetworkTexture tex;
		}

		// Token: 0x02001544 RID: 5444
		[Token(Token = "0x2001544")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EE56C", Offset = "0x10EE56C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005E19 RID: 24089 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E19")]
			[Address(RVA = "0x1CBB300", Offset = "0x1CBB300", VA = "0x7BBC4BB300")]
			public <>c()
			{
			}

			// Token: 0x06005E1A RID: 24090 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005E1A")]
			[Address(RVA = "0x1CBB308", Offset = "0x1CBB308", VA = "0x7BBC4BB308")]
			internal CommonRewardItemInfo <OnGotReward>b__18_0(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x06005E1B RID: 24091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E1B")]
			[Address(RVA = "0x1CBB314", Offset = "0x1CBB314", VA = "0x7BBC4BB314")]
			internal void <InitGotoBtn>b__20_0()
			{
			}

			// Token: 0x04007F89 RID: 32649
			[Token(Token = "0x4007F89")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UILinkActivityDetailController.<>c <>9;

			// Token: 0x04007F8A RID: 32650
			[Token(Token = "0x4007F8A")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__18_0;

			// Token: 0x04007F8B RID: 32651
			[Token(Token = "0x4007F8B")]
			[FieldOffset(Offset = "0x10")]
			public static EventDelegate.Callback <>9__20_0;
		}

		// Token: 0x02001545 RID: 5445
		[Token(Token = "0x2001545")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EE57C", Offset = "0x10EE57C")]
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x06005E1C RID: 24092 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E1C")]
			[Address(RVA = "0x1CBAED8", Offset = "0x1CBAED8", VA = "0x7BBC4BAED8")]
			public <>c__DisplayClass22_0()
			{
			}

			// Token: 0x06005E1D RID: 24093 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E1D")]
			[Address(RVA = "0x1CBB4D4", Offset = "0x1CBB4D4", VA = "0x7BBC4BB4D4")]
			internal void <InitClaimBtn>b__0()
			{
			}

			// Token: 0x04007F8C RID: 32652
			[Token(Token = "0x4007F8C")]
			[FieldOffset(Offset = "0x10")]
			public UILinkActivityDetailController <>4__this;

			// Token: 0x04007F8D RID: 32653
			[Token(Token = "0x4007F8D")]
			[FieldOffset(Offset = "0x18")]
			public Transform parent;
		}
	}
}
