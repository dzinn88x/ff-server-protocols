using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020017B0 RID: 6064
	[Token(Token = "0x20017B0")]
	public class UIEquipSetItemController : UIBaseController
	{
		// Token: 0x060073ED RID: 29677 RVA: 0x00020370 File Offset: 0x0001E570
		[Token(Token = "0x60073ED")]
		[Address(RVA = "0x1E79258", Offset = "0x1E79258", VA = "0x7BBC679258")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060073EE RID: 29678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073EE")]
		[Address(RVA = "0x1E792A8", Offset = "0x1E792A8", VA = "0x7BBC6792A8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060073EF RID: 29679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073EF")]
		[Address(RVA = "0x1E793E4", Offset = "0x1E793E4", VA = "0x7BBC6793E4")]
		public void SetUIData(int index, LinkEquipSetData data)
		{
		}

		// Token: 0x060073F0 RID: 29680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073F0")]
		[Address(RVA = "0x1E79614", Offset = "0x1E79614", VA = "0x7BBC679614")]
		private void SetEquips(EquipIdCountDataList data, GameObject widget, UILabel nameLabel, UISprite icon, bool bigIcon = false)
		{
		}

		// Token: 0x060073F1 RID: 29681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073F1")]
		[Address(RVA = "0x1E797A0", Offset = "0x1E797A0", VA = "0x7BBC6797A0")]
		private nS}etYj SetEquipWidget(EquipIdCountDataList data, GameObject widget)
		{
			return null;
		}

		// Token: 0x060073F2 RID: 29682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073F2")]
		[Address(RVA = "0x1E798E4", Offset = "0x1E798E4", VA = "0x7BBC6798E4")]
		private void SetEquips(nS}etYj itemData, UILabel nameLabel, UISprite icon, bool bigIcon)
		{
		}

		// Token: 0x060073F3 RID: 29683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073F3")]
		[Address(RVA = "0x1E79668", Offset = "0x1E79668", VA = "0x7BBC679668")]
		private void SetArmor(EquipIdCountDataList data, GameObject widget, UISprite icon)
		{
		}

		// Token: 0x060073F4 RID: 29684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073F4")]
		[Address(RVA = "0x1E7939C", Offset = "0x1E7939C", VA = "0x7BBC67939C")]
		public void Highlight(bool highlight)
		{
		}

		// Token: 0x060073F5 RID: 29685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073F5")]
		[Address(RVA = "0x1E79A28", Offset = "0x1E79A28", VA = "0x7BBC679A28")]
		public void SetForbidChoose(bool choosed, string name = "")
		{
		}

		// Token: 0x060073F6 RID: 29686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073F6")]
		[Address(RVA = "0x1E79CD0", Offset = "0x1E79CD0", VA = "0x7BBC679CD0")]
		public void SetEscortModeInfo(string info)
		{
		}

		// Token: 0x060073F7 RID: 29687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073F7")]
		[Address(RVA = "0x1E79B3C", Offset = "0x1E79B3C", VA = "0x7BBC679B3C")]
		private void PlayForbidEffect(GameObject go, string name)
		{
		}

		// Token: 0x060073F8 RID: 29688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073F8")]
		[Address(RVA = "0x1E79D1C", Offset = "0x1E79D1C", VA = "0x7BBC679D1C")]
		private void OnClick()
		{
		}

		// Token: 0x060073F9 RID: 29689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073F9")]
		[Address(RVA = "0x1E79D80", Offset = "0x1E79D80", VA = "0x7BBC679D80")]
		public UIEquipSetItemController()
		{
		}

		// Token: 0x04008C14 RID: 35860
		[Token(Token = "0x4008C14")]
		[FieldOffset(Offset = "0x58")]
		private UIEquipSetItemView m_View;

		// Token: 0x04008C15 RID: 35861
		[Token(Token = "0x4008C15")]
		[FieldOffset(Offset = "0x60")]
		public int m_Index;

		// Token: 0x04008C16 RID: 35862
		[Token(Token = "0x4008C16")]
		[FieldOffset(Offset = "0x68")]
		public Action<int> OnSelect;

		// Token: 0x04008C17 RID: 35863
		[Token(Token = "0x4008C17")]
		[FieldOffset(Offset = "0x70")]
		public LinkEquipSetData m_equipSetData;

		// Token: 0x04008C18 RID: 35864
		[Token(Token = "0x4008C18")]
		[FieldOffset(Offset = "0x78")]
		public bool m_IsForbid;

		// Token: 0x020017B1 RID: 6065
		[Token(Token = "0x20017B1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F2954", Offset = "0x10F2954")]
		private sealed class <>c__DisplayClass15_0
		{
			// Token: 0x060073FA RID: 29690 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60073FA")]
			[Address(RVA = "0x1E79D14", Offset = "0x1E79D14", VA = "0x7BBC679D14")]
			public <>c__DisplayClass15_0()
			{
			}

			// Token: 0x060073FB RID: 29691 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60073FB")]
			[Address(RVA = "0x1E79D88", Offset = "0x1E79D88", VA = "0x7BBC679D88")]
			internal void <PlayForbidEffect>b__0()
			{
			}

			// Token: 0x04008C19 RID: 35865
			[Token(Token = "0x4008C19")]
			[FieldOffset(Offset = "0x10")]
			public UIEquipSetItemController <>4__this;

			// Token: 0x04008C1A RID: 35866
			[Token(Token = "0x4008C1A")]
			[FieldOffset(Offset = "0x18")]
			public string name;
		}
	}
}
