using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x020026FB RID: 9979
	[Token(Token = "0x20026FB")]
	internal class VehicleCameraBase : CameraControllerBase
	{
		// Token: 0x17000DF1 RID: 3569
		// (set) Token: 0x0600CFFE RID: 53246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000DF1")]
		public float VTe]rel
		{
			[Token(Token = "0x600CFFE")]
			[Address(RVA = "0x1DD8C8C", Offset = "0x1DD8C8C", VA = "0x7BBC5D8C8C")]
			set
			{
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (set) Token: 0x0600CFFF RID: 53247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000DF2")]
		public float HKLpWx~
		{
			[Token(Token = "0x600CFFF")]
			[Address(RVA = "0x1DD8C94", Offset = "0x1DD8C94", VA = "0x7BBC5D8C94")]
			set
			{
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x0600D000 RID: 53248 RVA: 0x00037B60 File Offset: 0x00035D60
		// (set) Token: 0x0600D001 RID: 53249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000DF3")]
		public float iTKLGm
		{
			[Token(Token = "0x600D000")]
			[Address(RVA = "0x1DE3010", Offset = "0x1DE3010", VA = "0x7BBC5E3010")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1149150", Offset = "0x1149150")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600D001")]
			[Address(RVA = "0x1DD8C9C", Offset = "0x1DD8C9C", VA = "0x7BBC5D8C9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1149160", Offset = "0x1149160")]
			set
			{
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x0600D002 RID: 53250 RVA: 0x00037B78 File Offset: 0x00035D78
		// (set) Token: 0x0600D003 RID: 53251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000DF4")]
		public float w\u0080rHGV{
		{
			[Token(Token = "0x600D002")]
			[Address(RVA = "0x1DE3018", Offset = "0x1DE3018", VA = "0x7BBC5E3018")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1149170", Offset = "0x1149170")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600D003")]
			[Address(RVA = "0x1DD8CA4", Offset = "0x1DD8CA4", VA = "0x7BBC5D8CA4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1149180", Offset = "0x1149180")]
			set
			{
			}
		}

		// Token: 0x0600D004 RID: 53252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D004")]
		[Address(RVA = "0x1DE3020", Offset = "0x1DE3020", VA = "0x7BBC5E3020", Slot = "5")]
		protected override void rGiiBsg()
		{
		}

		// Token: 0x0600D005 RID: 53253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D005")]
		[Address(RVA = "0x1DE31E0", Offset = "0x1DE31E0", VA = "0x7BBC5E31E0", Slot = "6")]
		public override void OnCameraChanged()
		{
		}

		// Token: 0x0600D006 RID: 53254 RVA: 0x00037B90 File Offset: 0x00035D90
		[Token(Token = "0x600D006")]
		[Address(RVA = "0x1DE3488", Offset = "0x1DE3488", VA = "0x7BBC5E3488")]
		protected bool {s\u0081Tkay(Vector3 sXk\u0082ggP, Vector3 wDNWf}s, out Vector3 ]kWkjCQ)
		{
			return default(bool);
		}

		// Token: 0x0600D007 RID: 53255 RVA: 0x00037BA8 File Offset: 0x00035DA8
		[Token(Token = "0x600D007")]
		[Address(RVA = "0x1DE35E0", Offset = "0x1DE35E0", VA = "0x7BBC5E35E0")]
		public float CalculateCollisionBackOffset(Vector3 bQ\u0080i\u0081MI, Vector3 \u0080kKCBsw, float quqeANe, [Optional] string jw^HU\u0081U)
		{
			return 0f;
		}

		// Token: 0x0600D008 RID: 53256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D008")]
		[Address(RVA = "0x1DE4010", Offset = "0x1DE4010", VA = "0x7BBC5E4010")]
		public VehicleCameraBase()
		{
		}

		// Token: 0x04010306 RID: 66310
		[Token(Token = "0x4010306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint FRY\u0082\u0081f\u007F;

		// Token: 0x04010307 RID: 66311
		[Token(Token = "0x4010307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float TargetFieldOfView;

		// Token: 0x04010308 RID: 66312
		[Token(Token = "0x4010308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float MinimumFOV;

		// Token: 0x04010309 RID: 66313
		[Token(Token = "0x4010309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float MaximumFOV;

		// Token: 0x0401030A RID: 66314
		[Token(Token = "0x401030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float MaximumTilt;

		// Token: 0x0401030B RID: 66315
		[Token(Token = "0x401030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float HeightDamping;

		// Token: 0x0401030C RID: 66316
		[Token(Token = "0x401030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float RotationDamping;

		// Token: 0x0401030D RID: 66317
		[Token(Token = "0x401030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float MaxRotationDamping;

		// Token: 0x0401030E RID: 66318
		[Token(Token = "0x401030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float N;

		// Token: 0x0401030F RID: 66319
		[Token(Token = "0x401030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected ]u\u007Fdcei qpiyChe;

		// Token: 0x04010310 RID: 66320
		[Token(Token = "0x4010310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected float xy]w;

		// Token: 0x04010311 RID: 66321
		[Token(Token = "0x4010311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		protected float I^cB\u0080RO;

		// Token: 0x04010312 RID: 66322
		[Token(Token = "0x4010312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1130CF4", Offset = "0x1130CF4")]
		private float <vN\u007FoIwW>k__BackingField;

		// Token: 0x04010313 RID: 66323
		[Token(Token = "0x4010313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1130D04", Offset = "0x1130D04")]
		private float <HfR}hZ[>k__BackingField;

		// Token: 0x04010314 RID: 66324
		[Token(Token = "0x4010314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 \u0080j^\u0082f|{;

		// Token: 0x04010315 RID: 66325
		[Token(Token = "0x4010315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float EiMjOUW;

		// Token: 0x04010316 RID: 66326
		[Token(Token = "0x4010316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected MDsfkBx ihduwXc;
	}
}
