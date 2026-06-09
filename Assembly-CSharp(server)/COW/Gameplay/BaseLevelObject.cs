using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002813 RID: 10259
	[Token(Token = "0x2002813")]
	public abstract class BaseLevelObject : COWReplicationEntity
	{
		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x0600D7FE RID: 55294 RVA: 0x0003BAC0 File Offset: 0x00039CC0
		// (set) Token: 0x0600D7FF RID: 55295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EB7")]
		public aZ cl^JjKj
		{
			[Token(Token = "0x600D7FE")]
			[Address(RVA = "0x18DECD8", Offset = "0x18DECD8", VA = "0x7BBC0DECD8")]
			get
			{
				return aZ.Invalid;
			}
			[Token(Token = "0x600D7FF")]
			[Address(RVA = "0x18DED58", Offset = "0x18DED58", VA = "0x7BBC0DED58")]
			set
			{
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x0600D800 RID: 55296 RVA: 0x0003BAD8 File Offset: 0x00039CD8
		// (set) Token: 0x0600D801 RID: 55297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EB8")]
		public uint qV
		{
			[Token(Token = "0x600D800")]
			[Address(RVA = "0x18DED60", Offset = "0x18DED60", VA = "0x7BBC0DED60")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600D801")]
			[Address(RVA = "0x18DEDE0", Offset = "0x18DEDE0", VA = "0x7BBC0DEDE0")]
			set
			{
			}
		}

		// Token: 0x0600D802 RID: 55298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D802")]
		[Address(RVA = "0x18DEDE8", Offset = "0x18DEDE8", VA = "0x7BBC0DEDE8", Slot = "26")]
		public virtual void DoAction(params object[] OSvO{nh)
		{
		}

		// Token: 0x0600D803 RID: 55299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D803")]
		[Address(RVA = "0x18DEDEC", Offset = "0x18DEDEC", VA = "0x7BBC0DEDEC", Slot = "27")]
		public virtual void SyncAction(params object[] OSvO{nh)
		{
		}

		// Token: 0x0600D804 RID: 55300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D804")]
		[Address(RVA = "0x18DEDF0", Offset = "0x18DEDF0", VA = "0x7BBC0DEDF0", Slot = "12")]
		protected override void OnStart()
		{
		}

		// Token: 0x0600D805 RID: 55301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D805")]
		[Address(RVA = "0x18DEE24", Offset = "0x18DEE24", VA = "0x7BBC0DEE24", Slot = "13")]
		protected override void OnOnDestroy()
		{
		}

		// Token: 0x0600D806 RID: 55302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D806")]
		[Address(RVA = "0x18DEF04", Offset = "0x18DEF04", VA = "0x7BBC0DEF04")]
		public string GetObjectName()
		{
			return null;
		}

		// Token: 0x0600D807 RID: 55303 RVA: 0x0003BAF0 File Offset: 0x00039CF0
		[Token(Token = "0x600D807")]
		[Address(RVA = "0x18DEF94", Offset = "0x18DEF94", VA = "0x7BBC0DEF94")]
		public uint GetObjectID()
		{
			return 0U;
		}

		// Token: 0x0600D808 RID: 55304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D808")]
		[Address(RVA = "0x18DF014", Offset = "0x18DF014", VA = "0x7BBC0DF014", Slot = "28")]
		protected virtual void SXUlsSA()
		{
		}

		// Token: 0x0600D809 RID: 55305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D809")]
		[Address(RVA = "0x18DF1F0", Offset = "0x18DF1F0", VA = "0x7BBC0DF1F0", Slot = "29")]
		public virtual void RegisterThis(aZ PyEIVka, uint {NRR\u0081yd)
		{
		}

		// Token: 0x0600D80A RID: 55306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D80A")]
		[Address(RVA = "0x18DF018", Offset = "0x18DF018", VA = "0x7BBC0DF018")]
		private void xphFvqh()
		{
		}

		// Token: 0x0600D80B RID: 55307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D80B")]
		[Address(RVA = "0x18DEE4C", Offset = "0x18DEE4C", VA = "0x7BBC0DEE4C")]
		public void UnRegisterThis()
		{
		}

		// Token: 0x0600D80C RID: 55308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D80C")]
		[Address(RVA = "0x18DF344", Offset = "0x18DF344", VA = "0x7BBC0DF344", Slot = "30")]
		public virtual void Hide()
		{
		}

		// Token: 0x0600D80D RID: 55309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D80D")]
		[Address(RVA = "0x18DF37C", Offset = "0x18DF37C", VA = "0x7BBC0DF37C", Slot = "31")]
		public virtual void Show(bool UOhq{XI)
		{
		}

		// Token: 0x0600D80E RID: 55310 RVA: 0x0003BB08 File Offset: 0x00039D08
		[Token(Token = "0x600D80E")]
		[Address(RVA = "0x18DF3B8", Offset = "0x18DF3B8", VA = "0x7BBC0DF3B8", Slot = "22")]
		protected override int GetMaxRepDataCount()
		{
			return 0;
		}

		// Token: 0x0600D80F RID: 55311
		[Token(Token = "0x600D80F")]
		protected abstract string GetObjectTag();

		// Token: 0x0600D810 RID: 55312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D810")]
		[Address(RVA = "0x18DF3C0", Offset = "0x18DF3C0", VA = "0x7BBC0DF3C0", Slot = "33")]
		public virtual void TakeDamage(int |moXXXV)
		{
		}

		// Token: 0x0600D811 RID: 55313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D811")]
		[Address(RVA = "0x18DF3C4", Offset = "0x18DF3C4", VA = "0x7BBC0DF3C4", Slot = "34")]
		public virtual void TakeHealing(int wE~rpy\u0082, {QAb\u0082~u a\u0082uxIoj, int OhggZRq, [Optional] Vector3 `oVk\u0080^H, [Optional] Vector3 ft|sF}F, [Optional] List<float> `KEFVvE)
		{
		}

		// Token: 0x0600D812 RID: 55314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D812")]
		[Address(RVA = "0x18DF3C8", Offset = "0x18DF3C8", VA = "0x7BBC0DF3C8")]
		public void EnterMovePlatformByID(uint mHkAB\u0080w, Vector3 eYhEF}C)
		{
		}

		// Token: 0x0600D813 RID: 55315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D813")]
		[Address(RVA = "0x18DF624", Offset = "0x18DF624", VA = "0x7BBC0DF624")]
		public void EnterMovePlatform(LevelMovePlatform vu\u0081Fwkg, Vector3 eYhEF}C)
		{
		}

		// Token: 0x0600D814 RID: 55316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D814")]
		[Address(RVA = "0x18DF74C", Offset = "0x18DF74C", VA = "0x7BBC0DF74C")]
		protected BaseLevelObject()
		{
		}

		// Token: 0x0401086A RID: 67690
		[Token(Token = "0x401086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected aZ uNlNdAH;

		// Token: 0x0401086B RID: 67691
		[Token(Token = "0x401086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected uint UM;

		// Token: 0x0401086C RID: 67692
		[Token(Token = "0x401086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		protected bool RsfQzpI;

		// Token: 0x0401086D RID: 67693
		[Token(Token = "0x401086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		protected bool hEEypnj;

		// Token: 0x0401086E RID: 67694
		[Token(Token = "0x401086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected string iIRhLNa;

		// Token: 0x0401086F RID: 67695
		[Token(Token = "0x401086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public uint m_PlatformID;

		// Token: 0x04010870 RID: 67696
		[Token(Token = "0x4010870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[HideInInspector]
		public Vector3 m_LocalPositionOnPlatform;
	}
}
