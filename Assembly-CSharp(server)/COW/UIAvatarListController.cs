using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020016AF RID: 5807
	[Token(Token = "0x20016AF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F09A4", Offset = "0x10F09A4")]
	public class UIAvatarListController : UINavigationController, IEasyList
	{
		// Token: 0x17000919 RID: 2329
		// (set) Token: 0x060069F2 RID: 27122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000919")]
		public uint CurrentShowAvatarID
		{
			[Token(Token = "0x60069F2")]
			[Address(RVA = "0x1B2A5DC", Offset = "0x1B2A5DC", VA = "0x7BBC32A5DC")]
			set
			{
			}
		}

		// Token: 0x1700091A RID: 2330
		// (set) Token: 0x060069F3 RID: 27123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700091A")]
		public bool ShowLatest
		{
			[Token(Token = "0x60069F3")]
			[Address(RVA = "0x1B2AD10", Offset = "0x1B2AD10", VA = "0x7BBC32AD10")]
			set
			{
			}
		}

		// Token: 0x060069F4 RID: 27124 RVA: 0x0001E030 File Offset: 0x0001C230
		[Token(Token = "0x60069F4")]
		[Address(RVA = "0x1B2AD1C", Offset = "0x1B2AD1C", VA = "0x7BBC32AD1C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060069F5 RID: 27125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069F5")]
		[Address(RVA = "0x1B2AD6C", Offset = "0x1B2AD6C", VA = "0x7BBC32AD6C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060069F6 RID: 27126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069F6")]
		[Address(RVA = "0x1B2AFAC", Offset = "0x1B2AFAC", VA = "0x7BBC32AFAC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060069F7 RID: 27127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069F7")]
		[Address(RVA = "0x1B2B078", Offset = "0x1B2B078", VA = "0x7BBC32B078")]
		private void StopNewbieGuide(params object[] args)
		{
		}

		// Token: 0x060069F8 RID: 27128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069F8")]
		[Address(RVA = "0x1B2B110", Offset = "0x1B2B110", VA = "0x7BBC32B110", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060069F9 RID: 27129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069F9")]
		[Address(RVA = "0x1B2B118", Offset = "0x1B2B118", VA = "0x7BBC32B118", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x060069FA RID: 27130 RVA: 0x0001E048 File Offset: 0x0001C248
		[Token(Token = "0x60069FA")]
		[Address(RVA = "0x1B2B140", Offset = "0x1B2B140", VA = "0x7BBC32B140", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x060069FB RID: 27131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069FB")]
		[Address(RVA = "0x1B2B148", Offset = "0x1B2B148", VA = "0x7BBC32B148", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060069FC RID: 27132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069FC")]
		[Address(RVA = "0x1B2A5E4", Offset = "0x1B2A5E4", VA = "0x7BBC32A5E4")]
		public void Refresh()
		{
		}

		// Token: 0x060069FD RID: 27133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069FD")]
		[Address(RVA = "0x1B2B318", Offset = "0x1B2B318", VA = "0x7BBC32B318", Slot = "39")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x060069FE RID: 27134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069FE")]
		[Address(RVA = "0x1B2B3AC", Offset = "0x1B2B3AC", VA = "0x7BBC32B3AC", Slot = "40")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x060069FF RID: 27135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069FF")]
		[Address(RVA = "0x1B2B3DC", Offset = "0x1B2B3DC", VA = "0x7BBC32B3DC")]
		public UIAvatarListController()
		{
		}

		// Token: 0x06006A00 RID: 27136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A00")]
		[Address(RVA = "0x1B2B3E4", Offset = "0x1B2B3E4", VA = "0x7BBC32B3E4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140D94", Offset = "0x1140D94")]
		private void <OnUIInit>b__12_0()
		{
		}

		// Token: 0x040086A4 RID: 34468
		[Token(Token = "0x40086A4")]
		[FieldOffset(Offset = "0xB0")]
		private UIAvatarListView m_View;

		// Token: 0x040086A5 RID: 34469
		[Token(Token = "0x40086A5")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelAvatarProfile m_Model;

		// Token: 0x040086A6 RID: 34470
		[Token(Token = "0x40086A6")]
		[FieldOffset(Offset = "0xC0")]
		private uint m_CurrentShowAvatarID;

		// Token: 0x040086A7 RID: 34471
		[Token(Token = "0x40086A7")]
		private const float ITEM_WIDTH = 256f;

		// Token: 0x040086A8 RID: 34472
		[Token(Token = "0x40086A8")]
		private const float ITEM_HEIGHT = 365f;

		// Token: 0x040086A9 RID: 34473
		[Token(Token = "0x40086A9")]
		[FieldOffset(Offset = "0xC8")]
		private UIGuideTipsController m_GuideTipsCtrl;

		// Token: 0x040086AA RID: 34474
		[Token(Token = "0x40086AA")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_ShowLatest;

		// Token: 0x020016B0 RID: 5808
		[Token(Token = "0x20016B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F09DC", Offset = "0x10F09DC")]
		private sealed class <>c__DisplayClass19_0
		{
			// Token: 0x06006A01 RID: 27137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A01")]
			[Address(RVA = "0x1B2B18C", Offset = "0x1B2B18C", VA = "0x7BBC32B18C")]
			public <>c__DisplayClass19_0()
			{
			}

			// Token: 0x06006A02 RID: 27138 RVA: 0x0001E060 File Offset: 0x0001C260
			[Token(Token = "0x6006A02")]
			[Address(RVA = "0x1B2B5E4", Offset = "0x1B2B5E4", VA = "0x7BBC32B5E4")]
			internal bool <Refresh>b__0(AvatarProfile a)
			{
				return default(bool);
			}

			// Token: 0x040086AB RID: 34475
			[Token(Token = "0x40086AB")]
			[FieldOffset(Offset = "0x10")]
			public UIModelAvatarProfile model;
		}

		// Token: 0x020016B1 RID: 5809
		[Token(Token = "0x20016B1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F09EC", Offset = "0x10F09EC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006A04 RID: 27140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A04")]
			[Address(RVA = "0x1B2B5A4", Offset = "0x1B2B5A4", VA = "0x7BBC32B5A4")]
			public <>c()
			{
			}

			// Token: 0x06006A05 RID: 27141 RVA: 0x0001E078 File Offset: 0x0001C278
			[Token(Token = "0x6006A05")]
			[Address(RVA = "0x1B2B5AC", Offset = "0x1B2B5AC", VA = "0x7BBC32B5AC")]
			internal int <Refresh>b__19_1(AvatarProfile a, AvatarProfile b)
			{
				return 0;
			}

			// Token: 0x040086AC RID: 34476
			[Token(Token = "0x40086AC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIAvatarListController.<>c <>9;

			// Token: 0x040086AD RID: 34477
			[Token(Token = "0x40086AD")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<AvatarProfile> <>9__19_1;
		}
	}
}
