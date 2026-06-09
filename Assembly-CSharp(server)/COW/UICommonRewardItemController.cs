using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001757 RID: 5975
	[Token(Token = "0x2001757")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1E54", Offset = "0x10F1E54")]
	public class UICommonRewardItemController : UIBaseController
	{
		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06007069 RID: 28777 RVA: 0x0001F7A0 File Offset: 0x0001D9A0
		[Token(Token = "0x17000931")]
		public bool CanEquip
		{
			[Token(Token = "0x6007069")]
			[Address(RVA = "0x1803F68", Offset = "0x1803F68", VA = "0x7BBC003F68")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x0600706A RID: 28778 RVA: 0x0001F7B8 File Offset: 0x0001D9B8
		[Token(Token = "0x17000932")]
		public uint RealItemID
		{
			[Token(Token = "0x600706A")]
			[Address(RVA = "0x1803F70", Offset = "0x1803F70", VA = "0x7BBC003F70")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600706B RID: 28779 RVA: 0x0001F7D0 File Offset: 0x0001D9D0
		[Token(Token = "0x600706B")]
		[Address(RVA = "0x1803F78", Offset = "0x1803F78", VA = "0x7BBC003F78")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600706C RID: 28780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600706C")]
		[Address(RVA = "0x1803FC8", Offset = "0x1803FC8", VA = "0x7BBC003FC8")]
		public UICommonRewardItemView GetRewardItemView()
		{
			return null;
		}

		// Token: 0x0600706D RID: 28781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600706D")]
		[Address(RVA = "0x1803FD0", Offset = "0x1803FD0", VA = "0x7BBC003FD0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600706E RID: 28782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600706E")]
		[Address(RVA = "0x18042EC", Offset = "0x18042EC", VA = "0x7BBC0042EC")]
		public UIWidget GetParticleWidget()
		{
			return null;
		}

		// Token: 0x0600706F RID: 28783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600706F")]
		[Address(RVA = "0x18043B0", Offset = "0x18043B0", VA = "0x7BBC0043B0")]
		public Transform GetChildStandardItemTrans()
		{
			return null;
		}

		// Token: 0x06007070 RID: 28784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007070")]
		public void SetViewInfo<T>(CommonRewardItemInfo info) where T : UIStandardItemMAXBController
		{
		}

		// Token: 0x06007071 RID: 28785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007071")]
		[Address(RVA = "0x1804440", Offset = "0x1804440", VA = "0x7BBC004440")]
		public void SetViewInfo(CommonRewardItemInfo info)
		{
		}

		// Token: 0x06007072 RID: 28786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007072")]
		public void SetOptionalBundleInfo<T>(CommonRewardItemInfo info, OptionalBundleShowData optionalBundleInfo) where T : UIStandardItemMAXBController
		{
		}

		// Token: 0x06007073 RID: 28787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007073")]
		[Address(RVA = "0x18049F8", Offset = "0x18049F8", VA = "0x7BBC0049F8")]
		public void ShowView(UICommonRewardWndController.WndStyleEnum style)
		{
		}

		// Token: 0x06007074 RID: 28788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007074")]
		[Address(RVA = "0x1804C64", Offset = "0x1804C64", VA = "0x7BBC004C64")]
		public void SetViewScale(float scale)
		{
		}

		// Token: 0x06007075 RID: 28789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007075")]
		[Address(RVA = "0x1804DC0", Offset = "0x1804DC0", VA = "0x7BBC004DC0")]
		public void SetVoucherAnimEnable(bool b)
		{
		}

		// Token: 0x06007076 RID: 28790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007076")]
		[Address(RVA = "0x1804E08", Offset = "0x1804E08", VA = "0x7BBC004E08")]
		public void PlayAudio(bool useNewAudio = false)
		{
		}

		// Token: 0x06007077 RID: 28791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007077")]
		[Address(RVA = "0x18041F0", Offset = "0x18041F0", VA = "0x7BBC0041F0")]
		public void SetToggleVisible(bool v)
		{
		}

		// Token: 0x06007078 RID: 28792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007078")]
		[Address(RVA = "0x1804F7C", Offset = "0x1804F7C", VA = "0x7BBC004F7C")]
		public void SetToggleCheckState()
		{
		}

		// Token: 0x06007079 RID: 28793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007079")]
		[Address(RVA = "0x1805154", Offset = "0x1805154", VA = "0x7BBC005154")]
		public void SetToggleUnCheckState()
		{
		}

		// Token: 0x0600707A RID: 28794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600707A")]
		[Address(RVA = "0x1805184", Offset = "0x1805184", VA = "0x7BBC005184")]
		public void SetToggleEquippedState()
		{
		}

		// Token: 0x0600707B RID: 28795 RVA: 0x0001F7E8 File Offset: 0x0001D9E8
		[Token(Token = "0x600707B")]
		[Address(RVA = "0x18051B4", Offset = "0x18051B4", VA = "0x7BBC0051B4")]
		public bool IsAlreadyEquipped()
		{
			return default(bool);
		}

		// Token: 0x0600707C RID: 28796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600707C")]
		[Address(RVA = "0x18045B8", Offset = "0x18045B8", VA = "0x7BBC0045B8")]
		private void SetRealItemID()
		{
		}

		// Token: 0x0600707D RID: 28797 RVA: 0x0001F800 File Offset: 0x0001DA00
		[Token(Token = "0x600707D")]
		[Address(RVA = "0x18046D4", Offset = "0x18046D4", VA = "0x7BBC0046D4")]
		private bool IsCanEquip()
		{
			return default(bool);
		}

		// Token: 0x0600707E RID: 28798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600707E")]
		[Address(RVA = "0x1804FAC", Offset = "0x1804FAC", VA = "0x7BBC004FAC")]
		private void SetToggleValue(bool v)
		{
		}

		// Token: 0x0600707F RID: 28799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600707F")]
		[Address(RVA = "0x18051CC", Offset = "0x18051CC", VA = "0x7BBC0051CC")]
		private void OnToggleSelected()
		{
		}

		// Token: 0x06007080 RID: 28800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007080")]
		[Address(RVA = "0x1806054", Offset = "0x1806054", VA = "0x7BBC006054")]
		private void OnOptionalToggleSelected()
		{
		}

		// Token: 0x06007081 RID: 28801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007081")]
		[Address(RVA = "0x1806214", Offset = "0x1806214", VA = "0x7BBC006214")]
		public void RefreshOptionalToggle(uint order)
		{
		}

		// Token: 0x06007082 RID: 28802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007082")]
		[Address(RVA = "0x1804FF4", Offset = "0x1804FF4", VA = "0x7BBC004FF4")]
		private void RefreshUI()
		{
		}

		// Token: 0x06007083 RID: 28803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007083")]
		[Address(RVA = "0x1806298", Offset = "0x1806298", VA = "0x7BBC006298")]
		public void SetUseNewGachaAnimatoin(bool useNewGachaAnimatoin)
		{
		}

		// Token: 0x06007084 RID: 28804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007084")]
		[Address(RVA = "0x1806364", Offset = "0x1806364", VA = "0x7BBC006364", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007085 RID: 28805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007085")]
		[Address(RVA = "0x180636C", Offset = "0x180636C", VA = "0x7BBC00636C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007086 RID: 28806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007086")]
		[Address(RVA = "0x1806374", Offset = "0x1806374", VA = "0x7BBC006374")]
		public UICommonRewardItemController()
		{
		}

		// Token: 0x04008A44 RID: 35396
		[Token(Token = "0x4008A44")]
		[FieldOffset(Offset = "0x58")]
		private UICommonRewardItemView m_View;

		// Token: 0x04008A45 RID: 35397
		[Token(Token = "0x4008A45")]
		[FieldOffset(Offset = "0x60")]
		private UIStandardItemMAXBController m_childController;

		// Token: 0x04008A46 RID: 35398
		[Token(Token = "0x4008A46")]
		[FieldOffset(Offset = "0x68")]
		public CommonRewardItemInfo m_Info;

		// Token: 0x04008A47 RID: 35399
		[Token(Token = "0x4008A47")]
		[FieldOffset(Offset = "0x70")]
		public OptionalBundleShowData m_OptionalBundleInfo;

		// Token: 0x04008A48 RID: 35400
		[Token(Token = "0x4008A48")]
		[FieldOffset(Offset = "0x78")]
		private bool m_CanEquip;

		// Token: 0x04008A49 RID: 35401
		[Token(Token = "0x4008A49")]
		[FieldOffset(Offset = "0x7C")]
		private uint m_RealItemId;

		// Token: 0x04008A4A RID: 35402
		[Token(Token = "0x4008A4A")]
		[FieldOffset(Offset = "0x80")]
		private UICommonRewardItemController.EquipmentState m_EquipmentState;

		// Token: 0x04008A4B RID: 35403
		[Token(Token = "0x4008A4B")]
		[FieldOffset(Offset = "0x84")]
		private bool IsOwnedLabelEnable;

		// Token: 0x02001758 RID: 5976
		[Token(Token = "0x2001758")]
		private enum EquipmentState
		{
			// Token: 0x04008A4D RID: 35405
			[Token(Token = "0x4008A4D")]
			STATE_NONE,
			// Token: 0x04008A4E RID: 35406
			[Token(Token = "0x4008A4E")]
			STATE_CHECK,
			// Token: 0x04008A4F RID: 35407
			[Token(Token = "0x4008A4F")]
			STATE_UNCHECK,
			// Token: 0x04008A50 RID: 35408
			[Token(Token = "0x4008A50")]
			STATE_EQUIPPED
		}

		// Token: 0x02001759 RID: 5977
		[Token(Token = "0x2001759")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F1E8C", Offset = "0x10F1E8C")]
		private sealed class <>c__DisplayClass31_0
		{
			// Token: 0x06007087 RID: 28807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007087")]
			[Address(RVA = "0x18051C4", Offset = "0x18051C4", VA = "0x7BBC0051C4")]
			public <>c__DisplayClass31_0()
			{
			}

			// Token: 0x06007088 RID: 28808 RVA: 0x0001F818 File Offset: 0x0001DA18
			[Token(Token = "0x6007088")]
			[Address(RVA = "0x1806384", Offset = "0x1806384", VA = "0x7BBC006384")]
			internal bool <IsCanEquip>b__0(PetInfo temp)
			{
				return default(bool);
			}

			// Token: 0x04008A51 RID: 35409
			[Token(Token = "0x4008A51")]
			[FieldOffset(Offset = "0x10")]
			public PetSkinData skinData;
		}
	}
}
