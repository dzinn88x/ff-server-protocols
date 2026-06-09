using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02001002 RID: 4098
	[Token(Token = "0x2001002")]
	public class ReusableObject : MonoBehaviour
	{
		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06003D63 RID: 15715 RVA: 0x000133E0 File Offset: 0x000115E0
		// (set) Token: 0x06003D64 RID: 15716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700071F")]
		public ResourceID ResID
		{
			[Token(Token = "0x6003D63")]
			[Address(RVA = "0x248FB7C", Offset = "0x248FB7C", VA = "0x7BBCC8FB7C")]
			get
			{
				return default(ResourceID);
			}
			[Token(Token = "0x6003D64")]
			[Address(RVA = "0x248FB84", Offset = "0x248FB84", VA = "0x7BBCC8FB84")]
			set
			{
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06003D65 RID: 15717 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003D66 RID: 15718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000720")]
		public IReusableObjectOwner OwnerEntity
		{
			[Token(Token = "0x6003D65")]
			[Address(RVA = "0x248FB8C", Offset = "0x248FB8C", VA = "0x7BBCC8FB8C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BF18", Offset = "0x113BF18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D66")]
			[Address(RVA = "0x248FB94", Offset = "0x248FB94", VA = "0x7BBCC8FB94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BF28", Offset = "0x113BF28")]
			set
			{
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06003D67 RID: 15719 RVA: 0x000133F8 File Offset: 0x000115F8
		[Token(Token = "0x17000721")]
		public bool IsInPool
		{
			[Token(Token = "0x6003D67")]
			[Address(RVA = "0x248FB9C", Offset = "0x248FB9C", VA = "0x7BBCC8FB9C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D68")]
		[Address(RVA = "0x248FBA4", Offset = "0x248FBA4", VA = "0x7BBCC8FBA4", Slot = "4")]
		public virtual void Prepare()
		{
		}

		// Token: 0x06003D69 RID: 15721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D69")]
		[Address(RVA = "0x248FBAC", Offset = "0x248FBAC", VA = "0x7BBCC8FBAC")]
		public void Recycle(float delayTime = 0f)
		{
		}

		// Token: 0x06003D6A RID: 15722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D6A")]
		[Address(RVA = "0x248FC64", Offset = "0x248FC64", VA = "0x7BBCC8FC64")]
		public void TemporyStopUsing()
		{
		}

		// Token: 0x06003D6B RID: 15723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D6B")]
		[Address(RVA = "0x248FD44", Offset = "0x248FD44", VA = "0x7BBCC8FD44", Slot = "5")]
		protected virtual void DoRecycle()
		{
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D6C")]
		[Address(RVA = "0x248FFA0", Offset = "0x248FFA0", VA = "0x7BBCC8FFA0")]
		public ReusableObject()
		{
		}

		// Token: 0x04004E29 RID: 20009
		[Token(Token = "0x4004E29")]
		[FieldOffset(Offset = "0x18")]
		private ResourceID _ResID;

		// Token: 0x04004E2A RID: 20010
		[Token(Token = "0x4004E2A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EA54", Offset = "0x112EA54")]
		private IReusableObjectOwner <OwnerEntity>k__BackingField;

		// Token: 0x04004E2B RID: 20011
		[Token(Token = "0x4004E2B")]
		[FieldOffset(Offset = "0x28")]
		private bool m_IsInPool;
	}
}
