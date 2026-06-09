using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020019AA RID: 6570
	[Token(Token = "0x20019AA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6CE4", Offset = "0x10F6CE4")]
	public class UIHudWereWolvesWolfCountController : UIBaseController
	{
		// Token: 0x0600868F RID: 34447 RVA: 0x000246A8 File Offset: 0x000228A8
		[Token(Token = "0x600868F")]
		[Address(RVA = "0x1D20D94", Offset = "0x1D20D94", VA = "0x7BBC520D94")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008690 RID: 34448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008690")]
		[Address(RVA = "0x1D20DE4", Offset = "0x1D20DE4", VA = "0x7BBC520DE4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008691 RID: 34449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008691")]
		[Address(RVA = "0x1D211F8", Offset = "0x1D211F8", VA = "0x7BBC5211F8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008692 RID: 34450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008692")]
		[Address(RVA = "0x1D212C4", Offset = "0x1D212C4", VA = "0x7BBC5212C4", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008693 RID: 34451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008693")]
		[Address(RVA = "0x1D21464", Offset = "0x1D21464", VA = "0x7BBC521464")]
		private void SetAliveWolfCount(uint cur_count, uint all_count)
		{
		}

		// Token: 0x06008694 RID: 34452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008694")]
		[Address(RVA = "0x1D21324", Offset = "0x1D21324", VA = "0x7BBC521324")]
		private void RefreshWolfCount(params object[] data)
		{
		}

		// Token: 0x06008695 RID: 34453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008695")]
		[Address(RVA = "0x1D2155C", Offset = "0x1D2155C", VA = "0x7BBC52155C")]
		public UIHudWereWolvesWolfCountController()
		{
		}

		// Token: 0x04009593 RID: 38291
		[Token(Token = "0x4009593")]
		[FieldOffset(Offset = "0x58")]
		private UIHudWereWolvesWolfCountView m_View;

		// Token: 0x04009594 RID: 38292
		[Token(Token = "0x4009594")]
		[FieldOffset(Offset = "0x60")]
		private GameObject[] m_wolfList;

		// Token: 0x04009595 RID: 38293
		[Token(Token = "0x4009595")]
		[FieldOffset(Offset = "0x68")]
		private GameObject[] m_deadWolfList;
	}
}
