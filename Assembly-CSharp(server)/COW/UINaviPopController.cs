using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A98 RID: 6808
	[Token(Token = "0x2001A98")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F860C", Offset = "0x10F860C")]
	internal class UINaviPopController : UINavigationController
	{
		// Token: 0x06008F73 RID: 36723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F73")]
		[Address(RVA = "0x14D4B48", Offset = "0x14D4B48", VA = "0x7BBBCD4B48", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008F74 RID: 36724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F74")]
		[Address(RVA = "0x14D4C54", Offset = "0x14D4C54", VA = "0x7BBBCD4C54", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008F75 RID: 36725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F75")]
		[Address(RVA = "0x14D7C74", Offset = "0x14D7C74", VA = "0x7BBBCD7C74", Slot = "39")]
		protected virtual void OnClickClose()
		{
		}

		// Token: 0x06008F76 RID: 36726 RVA: 0x00026358 File Offset: 0x00024558
		[Token(Token = "0x6008F76")]
		[Address(RVA = "0x14D7D10", Offset = "0x14D7D10", VA = "0x7BBBCD7D10", Slot = "37")]
		public override bool OverwriteBackButtonLogic()
		{
			return default(bool);
		}

		// Token: 0x06008F77 RID: 36727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F77")]
		[Address(RVA = "0x14D7D18", Offset = "0x14D7D18", VA = "0x7BBBCD7D18", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06008F78 RID: 36728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F78")]
		[Address(RVA = "0x14D58D8", Offset = "0x14D58D8", VA = "0x7BBBCD58D8")]
		public UINaviPopController()
		{
		}

		// Token: 0x04009BA6 RID: 39846
		[Token(Token = "0x4009BA6")]
		[FieldOffset(Offset = "0xAA")]
		protected bool m_NaviMaskState;

		// Token: 0x04009BA7 RID: 39847
		[Token(Token = "0x4009BA7")]
		[FieldOffset(Offset = "0xB0")]
		protected GameObject m_NaviMask;
	}
}
