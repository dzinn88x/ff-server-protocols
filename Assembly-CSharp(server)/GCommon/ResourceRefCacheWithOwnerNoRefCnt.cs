using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000FFE RID: 4094
	[Token(Token = "0x2000FFE")]
	public class ResourceRefCacheWithOwnerNoRefCnt : IResourceRefCacheWithOwner
	{
		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06003D29 RID: 15657 RVA: 0x00013230 File Offset: 0x00011430
		// (set) Token: 0x06003D2A RID: 15658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700071D")]
		public virtual bool NoCache
		{
			[Token(Token = "0x6003D29")]
			[Address(RVA = "0x248EEC8", Offset = "0x248EEC8", VA = "0x7BBCC8EEC8", Slot = "20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BEF8", Offset = "0x113BEF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003D2A")]
			[Address(RVA = "0x248EED0", Offset = "0x248EED0", VA = "0x7BBCC8EED0", Slot = "21")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BF08", Offset = "0x113BF08")]
			set
			{
			}
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D2B")]
		[Address(RVA = "0x248D7D0", Offset = "0x248D7D0", VA = "0x7BBCC8D7D0", Slot = "22")]
		public virtual void Clear()
		{
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D2C")]
		[Address(RVA = "0x248EEDC", Offset = "0x248EEDC", VA = "0x7BBCC8EEDC", Slot = "23")]
		public virtual UnityEngine.Object TryGet(ResourceID resId)
		{
			return null;
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D2D")]
		[Address(RVA = "0x248EF60", Offset = "0x248EF60", VA = "0x7BBCC8EF60", Slot = "24")]
		public virtual UnityEngine.Object GetAndRegister(object owner, ResourceID resId)
		{
			return null;
		}

		// Token: 0x06003D2E RID: 15662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D2E")]
		[Address(RVA = "0x248DA54", Offset = "0x248DA54", VA = "0x7BBCC8DA54")]
		protected static UnityEngine.Object LoadImpl(ResourceID resId, bool noCache)
		{
			return null;
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x00013248 File Offset: 0x00011448
		[Token(Token = "0x6003D2F")]
		[Address(RVA = "0x248EF98", Offset = "0x248EF98", VA = "0x7BBCC8EF98", Slot = "25")]
		public virtual bool HasUnRefedRes()
		{
			return default(bool);
		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D30")]
		[Address(RVA = "0x248EFA0", Offset = "0x248EFA0", VA = "0x7BBCC8EFA0", Slot = "26")]
		public virtual void Register(object owner, UnityEngine.Object res)
		{
		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D31")]
		[Address(RVA = "0x248EFA4", Offset = "0x248EFA4", VA = "0x7BBCC8EFA4", Slot = "27")]
		public virtual void UnRegister(object owner, UnityEngine.Object res)
		{
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D32")]
		[Address(RVA = "0x248EFA8", Offset = "0x248EFA8", VA = "0x7BBCC8EFA8", Slot = "28")]
		public virtual void UnRegisterAll(object owner)
		{
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x00013260 File Offset: 0x00011460
		[Token(Token = "0x6003D33")]
		[Address(RVA = "0x248EFAC", Offset = "0x248EFAC", VA = "0x7BBCC8EFAC", Slot = "29")]
		public virtual bool UnloadOneUnRefedRes()
		{
			return default(bool);
		}

		// Token: 0x06003D34 RID: 15668 RVA: 0x00013278 File Offset: 0x00011478
		[Token(Token = "0x6003D34")]
		[Address(RVA = "0x248EFB4", Offset = "0x248EFB4", VA = "0x7BBCC8EFB4", Slot = "30")]
		public virtual int UnloadAllUnRefedRes()
		{
			return 0;
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x00013290 File Offset: 0x00011490
		[Token(Token = "0x6003D35")]
		[Address(RVA = "0x248E404", Offset = "0x248E404", VA = "0x7BBCC8E404", Slot = "13")]
		public bool IsAsyncLoading()
		{
			return default(bool);
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x000132A8 File Offset: 0x000114A8
		[Token(Token = "0x6003D36")]
		[Address(RVA = "0x248EFBC", Offset = "0x248EFBC", VA = "0x7BBCC8EFBC", Slot = "14")]
		public bool IsAsyncLoading(object owner, ResourceID resId)
		{
			return default(bool);
		}

		// Token: 0x06003D37 RID: 15671 RVA: 0x000132C0 File Offset: 0x000114C0
		[Token(Token = "0x6003D37")]
		[Address(RVA = "0x248F270", Offset = "0x248F270", VA = "0x7BBCC8F270")]
		protected static uint LoadAsyncImpl(uint ticket, ResourceID resId, Action<uint, bool, UnityEngine.Object> callback, bool noCache)
		{
			return 0U;
		}

		// Token: 0x06003D38 RID: 15672 RVA: 0x000132D8 File Offset: 0x000114D8
		[Token(Token = "0x6003D38")]
		[Address(RVA = "0x248F324", Offset = "0x248F324", VA = "0x7BBCC8F324", Slot = "31")]
		public virtual uint GetAndRegisterAsync(object owner, ResourceID resId, uint ticket, Action<uint, UnityEngine.Object> callback)
		{
			return 0U;
		}

		// Token: 0x06003D39 RID: 15673 RVA: 0x000132F0 File Offset: 0x000114F0
		[Token(Token = "0x6003D39")]
		[Address(RVA = "0x248E9B0", Offset = "0x248E9B0", VA = "0x7BBCC8E9B0")]
		protected uint GetAndRegisterAsync(object owner, ResourceID resId, uint ticket, Action<uint, UnityEngine.Object> callback, bool checkCache)
		{
			return 0U;
		}

		// Token: 0x06003D3A RID: 15674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D3A")]
		[Address(RVA = "0x248F330", Offset = "0x248F330", VA = "0x7BBCC8F330", Slot = "32")]
		protected virtual void RemoveAndInvokeAsyncCallback(uint ticket, bool success, UnityEngine.Object obj)
		{
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D3B")]
		[Address(RVA = "0x248ECEC", Offset = "0x248ECEC", VA = "0x7BBCC8ECEC")]
		protected void DoInvokeAsyncCallback(uint ticket, UnityEngine.Object obj, ResourceRefCacheWithOwnerNoRefCnt.ResCallbackPair pair)
		{
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D3C")]
		[Address(RVA = "0x248F374", Offset = "0x248F374", VA = "0x7BBCC8F374", Slot = "33")]
		public virtual void CancelAsync(object owner, uint ticket)
		{
		}

		// Token: 0x06003D3D RID: 15677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D3D")]
		[Address(RVA = "0x248F538", Offset = "0x248F538", VA = "0x7BBCC8F538", Slot = "34")]
		public virtual void CancelAsyncs(object owner)
		{
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D3E")]
		[Address(RVA = "0x248F6DC", Offset = "0x248F6DC", VA = "0x7BBCC8F6DC", Slot = "35")]
		public virtual void CancelAllAsyncs()
		{
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D3F")]
		[Address(RVA = "0x248F850", Offset = "0x248F850", VA = "0x7BBCC8F850", Slot = "36")]
		public virtual void RemoveOwner(object owner)
		{
		}

		// Token: 0x06003D40 RID: 15680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D40")]
		[Address(RVA = "0x248F540", Offset = "0x248F540", VA = "0x7BBCC8F540")]
		protected void CancelAsyncs(object owner, bool remove)
		{
		}

		// Token: 0x06003D41 RID: 15681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D41")]
		[Address(RVA = "0x248F4B4", Offset = "0x248F4B4", VA = "0x7BBCC8F4B4")]
		protected void DoCancelAsync(uint ticket)
		{
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D42")]
		[Address(RVA = "0x248F92C", Offset = "0x248F92C", VA = "0x7BBCC8F92C")]
		protected void AddTicketOwner(object owner, uint ticket)
		{
		}

		// Token: 0x06003D43 RID: 15683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D43")]
		[Address(RVA = "0x248F9D0", Offset = "0x248F9D0", VA = "0x7BBCC8F9D0")]
		protected object GetAndRemoveTicketOwner(uint ticket)
		{
			return null;
		}

		// Token: 0x06003D44 RID: 15684 RVA: 0x00013308 File Offset: 0x00011508
		[Token(Token = "0x6003D44")]
		[Address(RVA = "0x248F3BC", Offset = "0x248F3BC", VA = "0x7BBCC8F3BC")]
		protected bool RemoveTicketOwner(uint ticket)
		{
			return default(bool);
		}

		// Token: 0x06003D45 RID: 15685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D45")]
		[Address(RVA = "0x248F148", Offset = "0x248F148", VA = "0x7BBCC8F148")]
		protected Dictionary<uint, ResourceRefCacheWithOwnerNoRefCnt.ResCallbackPair> GetAsyncCallbacks(object owner, bool create)
		{
			return null;
		}

		// Token: 0x06003D46 RID: 15686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D46")]
		[Address(RVA = "0x248F88C", Offset = "0x248F88C", VA = "0x7BBCC8F88C")]
		protected Dictionary<uint, ResourceRefCacheWithOwnerNoRefCnt.ResCallbackPair> RemoveAsyncCallbacks(object owner)
		{
			return null;
		}

		// Token: 0x06003D47 RID: 15687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D47")]
		[Address(RVA = "0x248FA70", Offset = "0x248FA70", VA = "0x7BBCC8FA70", Slot = "37")]
		protected virtual void RegisterAsyncCallback(object owner, uint ticket, ResourceID resId, Action<uint, UnityEngine.Object> callback)
		{
		}

		// Token: 0x06003D48 RID: 15688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D48")]
		[Address(RVA = "0x248EC20", Offset = "0x248EC20", VA = "0x7BBCC8EC20")]
		protected ResourceRefCacheWithOwnerNoRefCnt.ResCallbackPair RemoveAsyncCallback(uint ticket, out object owner)
		{
			return null;
		}

		// Token: 0x06003D49 RID: 15689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D49")]
		[Address(RVA = "0x248F430", Offset = "0x248F430", VA = "0x7BBCC8F430")]
		protected void RemoveAsyncCallback(object owner, uint ticket)
		{
		}

		// Token: 0x06003D4A RID: 15690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D4A")]
		[Address(RVA = "0x248EEC0", Offset = "0x248EEC0", VA = "0x7BBCC8EEC0")]
		public ResourceRefCacheWithOwnerNoRefCnt()
		{
		}

		// Token: 0x04004E19 RID: 19993
		[Token(Token = "0x4004E19")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EA44", Offset = "0x112EA44")]
		private bool <NoCache>k__BackingField;

		// Token: 0x04004E1A RID: 19994
		[Token(Token = "0x4004E1A")]
		private const int OwnerRequestsDefaultCapacity = 1;

		// Token: 0x04004E1B RID: 19995
		[Token(Token = "0x4004E1B")]
		[FieldOffset(Offset = "0x18")]
		protected Dictionary<object, Dictionary<uint, ResourceRefCacheWithOwnerNoRefCnt.ResCallbackPair>> m_OwnerToRequests;

		// Token: 0x04004E1C RID: 19996
		[Token(Token = "0x4004E1C")]
		[FieldOffset(Offset = "0x20")]
		protected Dictionary<uint, object> m_TicketToOwner;

		// Token: 0x02000FFF RID: 4095
		[Token(Token = "0x2000FFF")]
		public class ResCallbackPair
		{
			// Token: 0x06003D4B RID: 15691 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D4B")]
			[Address(RVA = "0x248FB40", Offset = "0x248FB40", VA = "0x7BBCC8FB40")]
			public ResCallbackPair(ResourceID resId, Action<uint, UnityEngine.Object> callback)
			{
			}

			// Token: 0x04004E1D RID: 19997
			[Token(Token = "0x4004E1D")]
			[FieldOffset(Offset = "0x10")]
			public ResourceID ResId;

			// Token: 0x04004E1E RID: 19998
			[Token(Token = "0x4004E1E")]
			[FieldOffset(Offset = "0x18")]
			public Action<uint, UnityEngine.Object> Callback;
		}
	}
}
