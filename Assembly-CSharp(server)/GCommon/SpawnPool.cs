using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000FF1 RID: 4081
	[Token(Token = "0x2000FF1")]
	public class SpawnPool
	{
		// Token: 0x06003C7E RID: 15486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C7E")]
		[Address(RVA = "0x249302C", Offset = "0x249302C", VA = "0x7BBCC9302C")]
		public SpawnPool(GameObject parent, ResourceID id)
		{
		}

		// Token: 0x06003C7F RID: 15487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C7F")]
		[Address(RVA = "0x2493130", Offset = "0x2493130", VA = "0x7BBCC93130")]
		public void InitPool(int num, uint maxSize = 0U)
		{
		}

		// Token: 0x06003C80 RID: 15488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C80")]
		[Address(RVA = "0x24934A4", Offset = "0x24934A4", VA = "0x7BBCC934A4")]
		public UnityEngine.Object GetRes(Transform parentTrans)
		{
			return null;
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C81")]
		[Address(RVA = "0x2493728", Offset = "0x2493728", VA = "0x7BBCC93728")]
		private void HandleObject(bool isNew, UnityEngine.Object obj, Transform parentTrans)
		{
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C82")]
		[Address(RVA = "0x2493978", Offset = "0x2493978", VA = "0x7BBCC93978")]
		private void RecycleRequest(SpawnPool.AsyncRequest request)
		{
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C83")]
		[Address(RVA = "0x2493A54", Offset = "0x2493A54", VA = "0x7BBCC93A54")]
		private SpawnPool.AsyncRequest GetAsyncRequest()
		{
			return null;
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x00012E58 File Offset: 0x00011058
		[Token(Token = "0x6003C84")]
		[Address(RVA = "0x2493B58", Offset = "0x2493B58", VA = "0x7BBCC93B58")]
		public bool InitPoolAsync(int num, uint maxSize = 0U)
		{
			return default(bool);
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x00012E70 File Offset: 0x00011070
		[Token(Token = "0x6003C85")]
		[Address(RVA = "0x2493D8C", Offset = "0x2493D8C", VA = "0x7BBCC93D8C")]
		public bool GetResAsync(Action<bool, UnityEngine.Object> callback, Transform parentTrans)
		{
			return default(bool);
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C86")]
		[Address(RVA = "0x2494084", Offset = "0x2494084", VA = "0x7BBCC94084")]
		public void CancelResAsyncLoading()
		{
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C87")]
		[Address(RVA = "0x24941B0", Offset = "0x24941B0", VA = "0x7BBCC941B0")]
		private void HandleNewObject(uint ticket, bool succeeded, UnityEngine.Object resObj)
		{
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C88")]
		[Address(RVA = "0x24945F4", Offset = "0x24945F4", VA = "0x7BBCC945F4")]
		public void RecycleRes(UnityEngine.Object obj, bool worldPositionStays = true)
		{
		}

		// Token: 0x06003C89 RID: 15497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C89")]
		[Address(RVA = "0x24933A4", Offset = "0x24933A4", VA = "0x7BBCC933A4")]
		public void HandleResEnqueue(UnityEngine.Object obj)
		{
		}

		// Token: 0x06003C8A RID: 15498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C8A")]
		[Address(RVA = "0x2494888", Offset = "0x2494888", VA = "0x7BBCC94888")]
		public void Clear()
		{
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C8B")]
		[Address(RVA = "0x2494A44", Offset = "0x2494A44", VA = "0x7BBCC94A44")]
		public void Destroy()
		{
		}

		// Token: 0x04004DAD RID: 19885
		[Token(Token = "0x4004DAD")]
		[FieldOffset(Offset = "0x10")]
		private Queue<UnityEngine.Object> m_FreeList;

		// Token: 0x04004DAE RID: 19886
		[Token(Token = "0x4004DAE")]
		[FieldOffset(Offset = "0x18")]
		private GameObject m_Parent;

		// Token: 0x04004DAF RID: 19887
		[Token(Token = "0x4004DAF")]
		[FieldOffset(Offset = "0x20")]
		private ResourceID m_resID;

		// Token: 0x04004DB0 RID: 19888
		[Token(Token = "0x4004DB0")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 m_ResourceOrgScale;

		// Token: 0x04004DB1 RID: 19889
		[Token(Token = "0x4004DB1")]
		[FieldOffset(Offset = "0x30")]
		private int m_GetResTimesTotal;

		// Token: 0x04004DB2 RID: 19890
		[Token(Token = "0x4004DB2")]
		[FieldOffset(Offset = "0x34")]
		private int m_ReturnResTimesTotal;

		// Token: 0x04004DB3 RID: 19891
		[Token(Token = "0x4004DB3")]
		[FieldOffset(Offset = "0x38")]
		private int m_PoolSizeDynamicMax;

		// Token: 0x04004DB4 RID: 19892
		[Token(Token = "0x4004DB4")]
		[FieldOffset(Offset = "0x3C")]
		private int m_InstanceNewResTimes;

		// Token: 0x04004DB5 RID: 19893
		[Token(Token = "0x4004DB5")]
		[FieldOffset(Offset = "0x40")]
		private List<UnityEngine.Object> m_ActiveList;

		// Token: 0x04004DB6 RID: 19894
		[Token(Token = "0x4004DB6")]
		[FieldOffset(Offset = "0x48")]
		private uint m_LimitMaxPoolSize;

		// Token: 0x04004DB7 RID: 19895
		[Token(Token = "0x4004DB7")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<SpawnPool.AsyncRequest> mAsyncRequestList;

		// Token: 0x04004DB8 RID: 19896
		[Token(Token = "0x4004DB8")]
		[FieldOffset(Offset = "0x58")]
		private readonly List<SpawnPool.AsyncRequest> mAsyncRequestPool;

		// Token: 0x04004DB9 RID: 19897
		[Token(Token = "0x4004DB9")]
		[FieldOffset(Offset = "0x60")]
		private uint mCurAsyncResLoadTicket;

		// Token: 0x02000FF2 RID: 4082
		[Token(Token = "0x2000FF2")]
		private class AsyncRequest
		{
			// Token: 0x06003C8C RID: 15500 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C8C")]
			[Address(RVA = "0x2493B48", Offset = "0x2493B48", VA = "0x7BBCC93B48")]
			public AsyncRequest()
			{
			}

			// Token: 0x04004DBA RID: 19898
			[Token(Token = "0x4004DBA")]
			[FieldOffset(Offset = "0x10")]
			public uint Ticket;

			// Token: 0x04004DBB RID: 19899
			[Token(Token = "0x4004DBB")]
			[FieldOffset(Offset = "0x18")]
			public Transform Parent;

			// Token: 0x04004DBC RID: 19900
			[Token(Token = "0x4004DBC")]
			[FieldOffset(Offset = "0x20")]
			public int Count;

			// Token: 0x04004DBD RID: 19901
			[Token(Token = "0x4004DBD")]
			[FieldOffset(Offset = "0x24")]
			public bool IsForInit;

			// Token: 0x04004DBE RID: 19902
			[Token(Token = "0x4004DBE")]
			[FieldOffset(Offset = "0x28")]
			public Action<bool, UnityEngine.Object> Callback;
		}
	}
}
