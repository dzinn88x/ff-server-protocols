using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02001000 RID: 4096
	[Token(Token = "0x2001000")]
	public class ResourceRefCacheWithOwner : ResourceRefCacheWithOwnerNoRefCnt
	{
		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06003D4C RID: 15692 RVA: 0x00013320 File Offset: 0x00011520
		// (set) Token: 0x06003D4D RID: 15693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700071E")]
		public override bool NoCache
		{
			[Token(Token = "0x6003D4C")]
			[Address(RVA = "0x248D6E4", Offset = "0x248D6E4", VA = "0x7BBCC8D6E4", Slot = "20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003D4D")]
			[Address(RVA = "0x248D6EC", Offset = "0x248D6EC", VA = "0x7BBCC8D6EC", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x06003D4E RID: 15694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D4E")]
		[Address(RVA = "0x248D6F0", Offset = "0x248D6F0", VA = "0x7BBCC8D6F0", Slot = "22")]
		public override void Clear()
		{
		}

		// Token: 0x06003D4F RID: 15695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D4F")]
		[Address(RVA = "0x248D7E0", Offset = "0x248D7E0", VA = "0x7BBCC8D7E0", Slot = "23")]
		public override UnityEngine.Object TryGet(ResourceID resId)
		{
			return null;
		}

		// Token: 0x06003D50 RID: 15696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D50")]
		[Address(RVA = "0x248D87C", Offset = "0x248D87C", VA = "0x7BBCC8D87C", Slot = "24")]
		public override UnityEngine.Object GetAndRegister(object owner, ResourceID resId)
		{
			return null;
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D51")]
		[Address(RVA = "0x248DD08", Offset = "0x248DD08", VA = "0x7BBCC8DD08", Slot = "26")]
		public override void Register(object owner, UnityEngine.Object res)
		{
		}

		// Token: 0x06003D52 RID: 15698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D52")]
		[Address(RVA = "0x248DAF0", Offset = "0x248DAF0", VA = "0x7BBCC8DAF0")]
		protected ResourceRefCacheWithOwner.ObjectRef Register(object owner, ResourceID resId, UnityEngine.Object res)
		{
			return null;
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D53")]
		[Address(RVA = "0x248DE7C", Offset = "0x248DE7C", VA = "0x7BBCC8DE7C", Slot = "27")]
		public override void UnRegister(object owner, UnityEngine.Object res)
		{
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D54")]
		[Address(RVA = "0x248DFD8", Offset = "0x248DFD8", VA = "0x7BBCC8DFD8", Slot = "28")]
		public override void UnRegisterAll(object owner)
		{
		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x00013338 File Offset: 0x00011538
		[Token(Token = "0x6003D55")]
		[Address(RVA = "0x248E2A8", Offset = "0x248E2A8", VA = "0x7BBCC8E2A8", Slot = "25")]
		public override bool HasUnRefedRes()
		{
			return default(bool);
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x00013350 File Offset: 0x00011550
		[Token(Token = "0x6003D56")]
		[Address(RVA = "0x248E314", Offset = "0x248E314", VA = "0x7BBCC8E314", Slot = "29")]
		public override bool UnloadOneUnRefedRes()
		{
			return default(bool);
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x00013368 File Offset: 0x00011568
		[Token(Token = "0x6003D57")]
		[Address(RVA = "0x248E6E4", Offset = "0x248E6E4", VA = "0x7BBCC8E6E4", Slot = "30")]
		public override int UnloadAllUnRefedRes()
		{
			return 0;
		}

		// Token: 0x06003D58 RID: 15704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D58")]
		[Address(RVA = "0x248DD90", Offset = "0x248DD90", VA = "0x7BBCC8DD90")]
		private ResourceRefCacheWithOwner.ObjectRef GetObjRef(UnityEngine.Object res, bool create)
		{
			return null;
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D59")]
		[Address(RVA = "0x248E8BC", Offset = "0x248E8BC", VA = "0x7BBCC8E8BC")]
		private HashSet<ResourceRefCacheWithOwner.ObjectRef> GetOwnerSet(object owner, bool create)
		{
			return null;
		}

		// Token: 0x06003D5A RID: 15706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D5A")]
		[Address(RVA = "0x248E0F4", Offset = "0x248E0F4", VA = "0x7BBCC8E0F4")]
		private HashSet<ResourceRefCacheWithOwner.ObjectRef> GetAndRemoveOwnerSet(object owner)
		{
			return null;
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x00013380 File Offset: 0x00011580
		[Token(Token = "0x6003D5B")]
		[Address(RVA = "0x248D990", Offset = "0x248D990", VA = "0x7BBCC8D990")]
		private bool IncreaseRefInNeed(ResourceRefCacheWithOwner.ObjectRef objRef, object owner)
		{
			return default(bool);
		}

		// Token: 0x06003D5C RID: 15708 RVA: 0x00013398 File Offset: 0x00011598
		[Token(Token = "0x6003D5C")]
		[Address(RVA = "0x248DF34", Offset = "0x248DF34", VA = "0x7BBCC8DF34")]
		private bool DecreaseRefInNeed(ResourceRefCacheWithOwner.ObjectRef objRef, object owner)
		{
			return default(bool);
		}

		// Token: 0x06003D5D RID: 15709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5D")]
		[Address(RVA = "0x248E1A0", Offset = "0x248E1A0", VA = "0x7BBCC8E1A0")]
		private void DecreaseRef(ResourceRefCacheWithOwner.ObjectRef objRef)
		{
		}

		// Token: 0x06003D5E RID: 15710 RVA: 0x000133B0 File Offset: 0x000115B0
		[Token(Token = "0x6003D5E")]
		[Address(RVA = "0x248E464", Offset = "0x248E464", VA = "0x7BBCC8E464")]
		private bool TryUnloadRes(ResourceRefCacheWithOwner.ObjectRef objRef)
		{
			return default(bool);
		}

		// Token: 0x06003D5F RID: 15711 RVA: 0x000133C8 File Offset: 0x000115C8
		[Token(Token = "0x6003D5F")]
		[Address(RVA = "0x248E9A4", Offset = "0x248E9A4", VA = "0x7BBCC8E9A4", Slot = "31")]
		public override uint GetAndRegisterAsync(object owner, ResourceID resId, uint ticket, Action<uint, UnityEngine.Object> callback)
		{
			return 0U;
		}

		// Token: 0x06003D60 RID: 15712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D60")]
		[Address(RVA = "0x248EBAC", Offset = "0x248EBAC", VA = "0x7BBCC8EBAC", Slot = "32")]
		protected override void RemoveAndInvokeAsyncCallback(uint ticket, bool success, UnityEngine.Object obj)
		{
		}

		// Token: 0x06003D61 RID: 15713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D61")]
		[Address(RVA = "0x248EDD8", Offset = "0x248EDD8", VA = "0x7BBCC8EDD8")]
		public ResourceRefCacheWithOwner()
		{
		}

		// Token: 0x04004E1F RID: 19999
		[Token(Token = "0x4004E1F")]
		private const object AnonymousOwner;

		// Token: 0x04004E20 RID: 20000
		[Token(Token = "0x4004E20")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<ResourceID, ResourceRefCacheWithOwner.ObjectRef> m_IdToRef;

		// Token: 0x04004E21 RID: 20001
		[Token(Token = "0x4004E21")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<UnityEngine.Object, ResourceRefCacheWithOwner.ObjectRef> m_ResToRefs;

		// Token: 0x04004E22 RID: 20002
		[Token(Token = "0x4004E22")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<object, HashSet<ResourceRefCacheWithOwner.ObjectRef>> m_OwnerToRef;

		// Token: 0x04004E23 RID: 20003
		[Token(Token = "0x4004E23")]
		[FieldOffset(Offset = "0x40")]
		private List<ResourceRefCacheWithOwner.ObjectRef> m_PendingUnloadReses;

		// Token: 0x04004E24 RID: 20004
		[Token(Token = "0x4004E24")]
		private const bool SkipUnloadingWhileAsyncLoading = true;

		// Token: 0x02001001 RID: 4097
		[Token(Token = "0x2001001")]
		protected class ObjectRef
		{
			// Token: 0x06003D62 RID: 15714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D62")]
			[Address(RVA = "0x248E844", Offset = "0x248E844", VA = "0x7BBCC8E844")]
			public ObjectRef()
			{
			}

			// Token: 0x04004E25 RID: 20005
			[Token(Token = "0x4004E25")]
			[FieldOffset(Offset = "0x10")]
			public UnityEngine.Object Res;

			// Token: 0x04004E26 RID: 20006
			[Token(Token = "0x4004E26")]
			[FieldOffset(Offset = "0x18")]
			public ResourceID ResID;

			// Token: 0x04004E27 RID: 20007
			[Token(Token = "0x4004E27")]
			[FieldOffset(Offset = "0x20")]
			public LinkedList<ResourceID> ResIDList;

			// Token: 0x04004E28 RID: 20008
			[Token(Token = "0x4004E28")]
			[FieldOffset(Offset = "0x28")]
			public short RefCnt;
		}
	}
}
