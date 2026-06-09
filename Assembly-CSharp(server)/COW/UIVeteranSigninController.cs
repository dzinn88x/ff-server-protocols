using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001BCF RID: 7119
	[Token(Token = "0x2001BCF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FAE5C", Offset = "0x10FAE5C")]
	public class UIVeteranSigninController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x060099E4 RID: 39396 RVA: 0x00028818 File Offset: 0x00026A18
		[Token(Token = "0x60099E4")]
		[Address(RVA = "0x1A0D168", Offset = "0x1A0D168", VA = "0x7BBC20D168")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060099E5 RID: 39397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099E5")]
		[Address(RVA = "0x1A0D1B8", Offset = "0x1A0D1B8", VA = "0x7BBC20D1B8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060099E6 RID: 39398 RVA: 0x00028830 File Offset: 0x00026A30
		[Token(Token = "0x60099E6")]
		[Address(RVA = "0x1A0D50C", Offset = "0x1A0D50C", VA = "0x7BBC20D50C", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060099E7 RID: 39399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099E7")]
		[Address(RVA = "0x1A0D570", Offset = "0x1A0D570", VA = "0x7BBC20D570", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060099E8 RID: 39400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099E8")]
		[Address(RVA = "0x1A0D8B4", Offset = "0x1A0D8B4", VA = "0x7BBC20D8B4")]
		private void RefreshUI()
		{
		}

		// Token: 0x060099E9 RID: 39401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099E9")]
		[Address(RVA = "0x1A0DD7C", Offset = "0x1A0DD7C", VA = "0x7BBC20DD7C")]
		private void ResetState()
		{
		}

		// Token: 0x060099EA RID: 39402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099EA")]
		[Address(RVA = "0x1A0E198", Offset = "0x1A0E198", VA = "0x7BBC20E198", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060099EB RID: 39403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099EB")]
		[Address(RVA = "0x1A0E2A4", Offset = "0x1A0E2A4", VA = "0x7BBC20E2A4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060099EC RID: 39404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099EC")]
		[Address(RVA = "0x1A0E3CC", Offset = "0x1A0E3CC", VA = "0x7BBC20E3CC")]
		public UIVeteranSigninController()
		{
		}

		// Token: 0x060099ED RID: 39405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099ED")]
		[Address(RVA = "0x1A0E43C", Offset = "0x1A0E43C", VA = "0x7BBC20E43C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144FB8", Offset = "0x1144FB8")]
		private void <OnUIInit>b__4_0(Texture texture)
		{
		}

		// Token: 0x0400A0FB RID: 41211
		[Token(Token = "0x400A0FB")]
		[FieldOffset(Offset = "0x58")]
		private UIVeteranSigninView m_View;

		// Token: 0x0400A0FC RID: 41212
		[Token(Token = "0x400A0FC")]
		[FieldOffset(Offset = "0x60")]
		private List<UIVeteranSigninItemController> m_ItemControllerList;

		// Token: 0x0400A0FD RID: 41213
		[Token(Token = "0x400A0FD")]
		[FieldOffset(Offset = "0x68")]
		private UIVeteranSigninItemController m_LastItemController;

		// Token: 0x02001BD0 RID: 7120
		[Token(Token = "0x2001BD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FAE94", Offset = "0x10FAE94")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060099EF RID: 39407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60099EF")]
			[Address(RVA = "0x1A0E5A8", Offset = "0x1A0E5A8", VA = "0x7BBC20E5A8")]
			public <>c()
			{
			}

			// Token: 0x060099F0 RID: 39408 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60099F0")]
			[Address(RVA = "0x1A0E5B0", Offset = "0x1A0E5B0", VA = "0x7BBC20E5B0")]
			internal CommonRewardItemInfo <OnDataChanged>b__6_0(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0400A0FE RID: 41214
			[Token(Token = "0x400A0FE")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIVeteranSigninController.<>c <>9;

			// Token: 0x0400A0FF RID: 41215
			[Token(Token = "0x400A0FF")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__6_0;
		}
	}
}
