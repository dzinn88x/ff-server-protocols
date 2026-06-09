using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200162C RID: 5676
	[Token(Token = "0x200162C")]
	public class UIHUDPVEMissionListController : UIBaseController
	{
		// Token: 0x06006617 RID: 26135 RVA: 0x0001D268 File Offset: 0x0001B468
		[Token(Token = "0x6006617")]
		[Address(RVA = "0x16BBF74", Offset = "0x16BBF74", VA = "0x7BBBEBBF74")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06006618 RID: 26136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000903")]
		public Transform ItemContainer
		{
			[Token(Token = "0x6006618")]
			[Address(RVA = "0x16BBFC4", Offset = "0x16BBFC4", VA = "0x7BBBEBBFC4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006619 RID: 26137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006619")]
		[Address(RVA = "0x16BC004", Offset = "0x16BC004", VA = "0x7BBBEBC004", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600661A RID: 26138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600661A")]
		[Address(RVA = "0x16BC068", Offset = "0x16BC068", VA = "0x7BBBEBC068")]
		public void OnMissionCome(string content, Vector3 topAnimStartLocalPos, float topAnimStartWidth)
		{
		}

		// Token: 0x0600661B RID: 26139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600661B")]
		[Address(RVA = "0x16BC3D4", Offset = "0x16BC3D4", VA = "0x7BBBEBC3D4")]
		private void PlayAnim()
		{
		}

		// Token: 0x0600661C RID: 26140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600661C")]
		[Address(RVA = "0x16BC5A4", Offset = "0x16BC5A4", VA = "0x7BBBEBC5A4")]
		private void TopItemAnim(UIHUDPVEMissionItemController item, Vector3 targetPos)
		{
		}

		// Token: 0x0600661D RID: 26141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600661D")]
		[Address(RVA = "0x16BC69C", Offset = "0x16BC69C", VA = "0x7BBBEBC69C")]
		private void LowItemAnim(UIHUDPVEMissionItemController item, Vector3 targetPos)
		{
		}

		// Token: 0x0600661E RID: 26142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600661E")]
		[Address(RVA = "0x16BC700", Offset = "0x16BC700", VA = "0x7BBBEBC700")]
		public UIHUDPVEMissionListController()
		{
		}

		// Token: 0x04008406 RID: 33798
		[Token(Token = "0x4008406")]
		private const int m_MaxItemNum = 6;

		// Token: 0x04008407 RID: 33799
		[Token(Token = "0x4008407")]
		[FieldOffset(Offset = "0x58")]
		private float m_ItemHeight;

		// Token: 0x04008408 RID: 33800
		[Token(Token = "0x4008408")]
		[FieldOffset(Offset = "0x5C")]
		private int m_CurTopItemIndex;

		// Token: 0x04008409 RID: 33801
		[Token(Token = "0x4008409")]
		[FieldOffset(Offset = "0x60")]
		private Coroutine m_AnimCoroutine;

		// Token: 0x0400840A RID: 33802
		[Token(Token = "0x400840A")]
		[FieldOffset(Offset = "0x68")]
		private Queue<UIHUDPVEMissionItemController> m_ItemControllers;

		// Token: 0x0400840B RID: 33803
		[Token(Token = "0x400840B")]
		[FieldOffset(Offset = "0x70")]
		private UIHUDPVEMissionListView m_View;
	}
}
