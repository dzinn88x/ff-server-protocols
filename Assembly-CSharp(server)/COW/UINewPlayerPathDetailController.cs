using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A9D RID: 6813
	[Token(Token = "0x2001A9D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F86C4", Offset = "0x10F86C4")]
	public class UINewPlayerPathDetailController : UIBaseController
	{
		// Token: 0x06008F93 RID: 36755 RVA: 0x000263E8 File Offset: 0x000245E8
		[Token(Token = "0x6008F93")]
		[Address(RVA = "0x1AF59A8", Offset = "0x1AF59A8", VA = "0x7BBC2F59A8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06008F95 RID: 36757 RVA: 0x00026400 File Offset: 0x00024600
		// (set) Token: 0x06008F94 RID: 36756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009EC")]
		public int Index
		{
			[Token(Token = "0x6008F95")]
			[Address(RVA = "0x1AF55C4", Offset = "0x1AF55C4", VA = "0x7BBC2F55C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11447D8", Offset = "0x11447D8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6008F94")]
			[Address(RVA = "0x1AF59F8", Offset = "0x1AF59F8", VA = "0x7BBC2F59F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11447C8", Offset = "0x11447C8")]
			private set
			{
			}
		}

		// Token: 0x06008F96 RID: 36758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F96")]
		[Address(RVA = "0x1AF5A00", Offset = "0x1AF5A00", VA = "0x7BBC2F5A00", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008F97 RID: 36759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F97")]
		[Address(RVA = "0x1AF55CC", Offset = "0x1AF55CC", VA = "0x7BBC2F55CC")]
		public void SetData(int index)
		{
		}

		// Token: 0x06008F98 RID: 36760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F98")]
		[Address(RVA = "0x1AF6160", Offset = "0x1AF6160", VA = "0x7BBC2F6160")]
		public void SelectSubItem(uint activityId)
		{
		}

		// Token: 0x06008F99 RID: 36761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F99")]
		[Address(RVA = "0x1AF5AEC", Offset = "0x1AF5AEC", VA = "0x7BBC2F5AEC")]
		private void UpdateView()
		{
		}

		// Token: 0x06008F9A RID: 36762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F9A")]
		[Address(RVA = "0x1AF63B4", Offset = "0x1AF63B4", VA = "0x7BBC2F63B4")]
		public UINewPlayerPathDetailController()
		{
		}

		// Token: 0x04009BBA RID: 39866
		[Token(Token = "0x4009BBA")]
		[FieldOffset(Offset = "0x58")]
		private UINewPlayerPathDetailView m_View;

		// Token: 0x04009BBB RID: 39867
		[Token(Token = "0x4009BBB")]
		[FieldOffset(Offset = "0x60")]
		private List<UINewPlayerPathDetailItemController> m_Items;

		// Token: 0x04009BBC RID: 39868
		[Token(Token = "0x4009BBC")]
		[FieldOffset(Offset = "0x68")]
		private uint m_CurSelectActivityId;

		// Token: 0x04009BBD RID: 39869
		[Token(Token = "0x4009BBD")]
		[FieldOffset(Offset = "0x70")]
		private List<Transform> m_ItemParents;

		// Token: 0x04009BBE RID: 39870
		[Token(Token = "0x4009BBE")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FA1C", Offset = "0x112FA1C")]
		private int <Index>k__BackingField;

		// Token: 0x02001A9E RID: 6814
		[Token(Token = "0x2001A9E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F86FC", Offset = "0x10F86FC")]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06008F9B RID: 36763 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008F9B")]
			[Address(RVA = "0x1AF6168", Offset = "0x1AF6168", VA = "0x7BBC2F6168")]
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x06008F9C RID: 36764 RVA: 0x00026418 File Offset: 0x00024618
			[Token(Token = "0x6008F9C")]
			[Address(RVA = "0x1AF644C", Offset = "0x1AF644C", VA = "0x7BBC2F644C")]
			internal bool <UpdateView>b__0(ActivityInfo temp)
			{
				return default(bool);
			}

			// Token: 0x04009BBF RID: 39871
			[Token(Token = "0x4009BBF")]
			[FieldOffset(Offset = "0x10")]
			public uint subId;
		}
	}
}
