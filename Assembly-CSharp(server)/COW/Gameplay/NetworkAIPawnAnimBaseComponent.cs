using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x020026C0 RID: 9920
	[Token(Token = "0x20026C0")]
	internal abstract class NetworkAIPawnAnimBaseComponent : MonoBehaviour
	{
		// Token: 0x0600CD84 RID: 52612
		[Token(Token = "0x600CD84")]
		public abstract void Init(NetworkAIPawn Foy[QIo, [Optional] Animation SWYpzZr, [Optional] Animator zk}jnsY);

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x0600CD85 RID: 52613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DC7")]
		public virtual Animation G~gQMFy
		{
			[Token(Token = "0x600CD85")]
			[Address(RVA = "0x19AC7F4", Offset = "0x19AC7F4", VA = "0x7BBC1AC7F4", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x0600CD86 RID: 52614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DC8")]
		public virtual Animator WGyzxs|
		{
			[Token(Token = "0x600CD86")]
			[Address(RVA = "0x19AC7FC", Offset = "0x19AC7FC", VA = "0x7BBC1AC7FC", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600CD87 RID: 52615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD87")]
		[Address(RVA = "0x19AC804", Offset = "0x19AC804", VA = "0x7BBC1AC804", Slot = "7")]
		public virtual void PlayAttack()
		{
		}

		// Token: 0x0600CD88 RID: 52616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD88")]
		[Address(RVA = "0x19AC808", Offset = "0x19AC808", VA = "0x7BBC1AC808", Slot = "8")]
		public virtual void PlayHitfly()
		{
		}

		// Token: 0x0600CD89 RID: 52617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD89")]
		[Address(RVA = "0x19AC80C", Offset = "0x19AC80C", VA = "0x7BBC1AC80C", Slot = "9")]
		public virtual void StopHitfly(bool BJhw`yf)
		{
		}

		// Token: 0x0600CD8A RID: 52618
		[Token(Token = "0x600CD8A")]
		public abstract void Dead(bool mHzuEX~, bool xIKfxdD);

		// Token: 0x0600CD8B RID: 52619
		[Token(Token = "0x600CD8B")]
		public abstract void SetSpeed(float aixgwfQ);

		// Token: 0x0600CD8C RID: 52620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD8C")]
		[Address(RVA = "0x19AC810", Offset = "0x19AC810", VA = "0x7BBC1AC810")]
		protected void xBIJMO]()
		{
		}

		// Token: 0x0600CD8D RID: 52621
		[Token(Token = "0x600CD8D")]
		public abstract bool PlaySkillAnim(\u0081}\u0082XTuu Gbf\u0082KIG, yE^UZPY nYt\u0080SAr, float i^XAdUl, float pGybwTv, bool kLVomUy);

		// Token: 0x0600CD8E RID: 52622 RVA: 0x000370F8 File Offset: 0x000352F8
		[Token(Token = "0x600CD8E")]
		[Address(RVA = "0x19AC948", Offset = "0x19AC948", VA = "0x7BBC1AC948", Slot = "13")]
		public virtual bool UpdateSkillAnim(\u0081}\u0082XTuu Gbf\u0082KIG, yE^UZPY nYt\u0080SAr, int XG\u0080\u007FO~O, float Mg|WFkb)
		{
			return default(bool);
		}

		// Token: 0x0600CD8F RID: 52623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD8F")]
		[Address(RVA = "0x19AC950", Offset = "0x19AC950", VA = "0x7BBC1AC950", Slot = "14")]
		public virtual void UpdateAnimSpeed(float \u0082Ujwl\u0080f)
		{
		}

		// Token: 0x0600CD90 RID: 52624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD90")]
		[Address(RVA = "0x19AC954", Offset = "0x19AC954", VA = "0x7BBC1AC954")]
		protected NetworkAIPawnAnimBaseComponent()
		{
		}

		// Token: 0x04010128 RID: 65832
		[Token(Token = "0x4010128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected NetworkAIPawn megx]fL;

		// Token: 0x04010129 RID: 65833
		[Token(Token = "0x4010129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool SkipDeathAnim;

		// Token: 0x0401012A RID: 65834
		[Token(Token = "0x401012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		protected float ]Vrv]~J;

		// Token: 0x0401012B RID: 65835
		[Token(Token = "0x401012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float o\u0082BkT{F;
	}
}
