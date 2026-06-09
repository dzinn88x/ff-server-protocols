using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x020026E3 RID: 9955
	[Token(Token = "0x20026E3")]
	internal abstract class AttackableEntity : COWReplicationEntity, \u0081{oGdwC
	{
		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x0600CF5B RID: 53083 RVA: 0x00037770 File Offset: 0x00035970
		// (set) Token: 0x0600CF5C RID: 53084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000DE1")]
		public bool \u0080xliDYS
		{
			[Token(Token = "0x600CF5B")]
			[Address(RVA = "0x18C63FC", Offset = "0x18C63FC", VA = "0x7BBC0C63FC", Slot = "31")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600CF5C")]
			[Address(RVA = "0x18C6404", Offset = "0x18C6404", VA = "0x7BBC0C6404")]
			set
			{
			}
		}

		// Token: 0x0600CF5D RID: 53085 RVA: 0x00037788 File Offset: 0x00035988
		[Token(Token = "0x600CF5D")]
		[Address(RVA = "0x18C644C", Offset = "0x18C644C", VA = "0x7BBC0C644C", Slot = "43")]
		public virtual Vector3 GetAttackableCenterWS()
		{
			return default(Vector3);
		}

		// Token: 0x0600CF5E RID: 53086 RVA: 0x000377A0 File Offset: 0x000359A0
		[Token(Token = "0x600CF5E")]
		[Address(RVA = "0x18C6480", Offset = "0x18C6480", VA = "0x7BBC0C6480", Slot = "44")]
		public virtual float GetAttackableRadius()
		{
			return 0f;
		}

		// Token: 0x0600CF5F RID: 53087 RVA: 0x000377B8 File Offset: 0x000359B8
		[Token(Token = "0x600CF5F")]
		[Address(RVA = "0x18C648C", Offset = "0x18C648C", VA = "0x7BBC0C648C", Slot = "45")]
		public virtual Vector3 GetHitDamagePos()
		{
			return default(Vector3);
		}

		// Token: 0x0600CF60 RID: 53088 RVA: 0x000377D0 File Offset: 0x000359D0
		[Token(Token = "0x600CF60")]
		[Address(RVA = "0x18C64C0", Offset = "0x18C64C0", VA = "0x7BBC0C64C0", Slot = "46")]
		public virtual bool NeedAssit()
		{
			return default(bool);
		}

		// Token: 0x0600CF61 RID: 53089 RVA: 0x000377E8 File Offset: 0x000359E8
		[Token(Token = "0x600CF61")]
		[Address(RVA = "0x18C64C8", Offset = "0x18C64C8", VA = "0x7BBC0C64C8", Slot = "47")]
		public virtual bool IsSameTeamWithPlayerID({QAb\u0082~u hVZ^Lay)
		{
			return default(bool);
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x0600CF62 RID: 53090 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CF63 RID: 53091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000DE2")]
		public Collider sM\u007FxNNp
		{
			[Token(Token = "0x600CF62")]
			[Address(RVA = "0x18C64D0", Offset = "0x18C64D0", VA = "0x7BBC0C64D0", Slot = "37")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1149110", Offset = "0x1149110")]
			get
			{
				return null;
			}
			[Token(Token = "0x600CF63")]
			[Address(RVA = "0x18C64D8", Offset = "0x18C64D8", VA = "0x7BBC0C64D8", Slot = "38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1149120", Offset = "0x1149120")]
			set
			{
			}
		}

		// Token: 0x0600CF64 RID: 53092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF64")]
		[Address(RVA = "0x18C64E0", Offset = "0x18C64E0", VA = "0x7BBC0C64E0", Slot = "48")]
		public virtual void TakeDamage(woZmHkA JkgWmeJ, [Optional] ohSG[ek \u0081{zLQ\u007FM, [Optional] List<float> `KEFVvE, uint ExBXjcs = 0U)
		{
		}

		// Token: 0x0600CF65 RID: 53093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF65")]
		[Address(RVA = "0x18C64E4", Offset = "0x18C64E4", VA = "0x7BBC0C64E4", Slot = "49")]
		public virtual void TakeHealing(int wE~rpy\u0082, {QAb\u0082~u a\u0082uxIoj, int OhggZRq, [Optional] Vector3 `oVk\u0080^H, [Optional] Vector3 ft|sF}F, [Optional] List<float> `KEFVvE)
		{
		}

		// Token: 0x0600CF66 RID: 53094 RVA: 0x00037800 File Offset: 0x00035A00
		[Token(Token = "0x600CF66")]
		[Address(RVA = "0x18C64E8", Offset = "0x18C64E8", VA = "0x7BBC0C64E8", Slot = "50")]
		public virtual bool IsVisible()
		{
			return default(bool);
		}

		// Token: 0x0600CF67 RID: 53095 RVA: 0x00037818 File Offset: 0x00035A18
		[Token(Token = "0x600CF67")]
		[Address(RVA = "0x18C651C", Offset = "0x18C651C", VA = "0x7BBC0C651C", Slot = "51")]
		public virtual bool IsStreamerVisible()
		{
			return default(bool);
		}

		// Token: 0x0600CF68 RID: 53096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF68")]
		[Address(RVA = "0x18C6524", Offset = "0x18C6524", VA = "0x7BBC0C6524", Slot = "12")]
		protected override void OnStart()
		{
		}

		// Token: 0x0600CF69 RID: 53097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF69")]
		[Address(RVA = "0x18C65E0", Offset = "0x18C65E0", VA = "0x7BBC0C65E0", Slot = "13")]
		protected override void OnOnDestroy()
		{
		}

		// Token: 0x0600CF6A RID: 53098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF6A")]
		[Address(RVA = "0x18C6628", Offset = "0x18C6628", VA = "0x7BBC0C6628", Slot = "52")]
		protected virtual void OnDead()
		{
		}

		// Token: 0x0600CF6B RID: 53099 RVA: 0x00037830 File Offset: 0x00035A30
		[Token(Token = "0x600CF6B")]
		[Address(RVA = "0x18C66D8", Offset = "0x18C66D8", VA = "0x7BBC0C66D8", Slot = "53")]
		public virtual uint GetAttackableID()
		{
			return 0U;
		}

		// Token: 0x0600CF6C RID: 53100 RVA: 0x00037848 File Offset: 0x00035A48
		[Token(Token = "0x600CF6C")]
		[Address(RVA = "0x18C66E0", Offset = "0x18C66E0", VA = "0x7BBC0C66E0", Slot = "54")]
		public virtual JDhUTU^ GetAttackableType()
		{
			return JDhUTU^.EAttackableType_None;
		}

		// Token: 0x0600CF6D RID: 53101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF6D")]
		[Address(RVA = "0x18C1E08", Offset = "0x18C1E08", VA = "0x7BBC0C1E08")]
		protected AttackableEntity()
		{
		}

		// Token: 0x0600CF6E RID: 53102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CF6E")]
		[Address(RVA = "0x18C66E8", Offset = "0x18C66E8", VA = "0x7BBC0C66E8", Slot = "26")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x04010246 RID: 66118
		[Token(Token = "0x4010246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool x^\u0081W^U\u007F;

		// Token: 0x04010247 RID: 66119
		[Token(Token = "0x4010247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1130C3C", Offset = "0x1130C3C")]
		private Collider <Y{Lwhxh>k__BackingField;
	}
}
