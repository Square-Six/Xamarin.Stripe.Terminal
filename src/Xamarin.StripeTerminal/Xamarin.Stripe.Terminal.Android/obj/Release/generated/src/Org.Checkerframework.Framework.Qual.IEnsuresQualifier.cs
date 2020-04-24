using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Checkerframework.Framework.Qual {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.checkerframework.framework.qual']/interface[@name='EnsuresQualifier']"
	[Register ("org/checkerframework/framework/qual/EnsuresQualifier", "", "Org.Checkerframework.Framework.Qual.IEnsuresQualifierInvoker")]
	public partial interface IEnsuresQualifier : global::Java.Lang.Annotation.IAnnotation {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.framework.qual']/interface[@name='EnsuresQualifier']/method[@name='expression' and count(parameter)=0]"
		[Register ("expression", "()[Ljava/lang/String;", "GetExpressionHandler:Org.Checkerframework.Framework.Qual.IEnsuresQualifierInvoker, Xamarin.Stripe.Terminal.Android")]
		string[] Expression ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.framework.qual']/interface[@name='EnsuresQualifier']/method[@name='qualifier' and count(parameter)=0]"
		[Register ("qualifier", "()Ljava/lang/Class;", "GetQualifierHandler:Org.Checkerframework.Framework.Qual.IEnsuresQualifierInvoker, Xamarin.Stripe.Terminal.Android")]
		global::Java.Lang.Class Qualifier ();

	}

	[global::Android.Runtime.Register ("org/checkerframework/framework/qual/EnsuresQualifier", DoNotGenerateAcw=true)]
	internal partial class IEnsuresQualifierInvoker : global::Java.Lang.Object, IEnsuresQualifier {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/checkerframework/framework/qual/EnsuresQualifier", typeof (IEnsuresQualifierInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IEnsuresQualifier GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEnsuresQualifier> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.checkerframework.framework.qual.EnsuresQualifier"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEnsuresQualifierInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_expression;
#pragma warning disable 0169
		static Delegate GetExpressionHandler ()
		{
			if (cb_expression == null)
				cb_expression = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Expression);
			return cb_expression;
		}

		static IntPtr n_Expression (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Checkerframework.Framework.Qual.IEnsuresQualifier __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Framework.Qual.IEnsuresQualifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Expression ());
		}
#pragma warning restore 0169

		IntPtr id_expression;
		public unsafe string[] Expression ()
		{
			if (id_expression == IntPtr.Zero)
				id_expression = JNIEnv.GetMethodID (class_ref, "expression", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_expression), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate cb_qualifier;
#pragma warning disable 0169
		static Delegate GetQualifierHandler ()
		{
			if (cb_qualifier == null)
				cb_qualifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Qualifier);
			return cb_qualifier;
		}

		static IntPtr n_Qualifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Checkerframework.Framework.Qual.IEnsuresQualifier __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Framework.Qual.IEnsuresQualifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Qualifier ());
		}
#pragma warning restore 0169

		IntPtr id_qualifier;
		public unsafe global::Java.Lang.Class Qualifier ()
		{
			if (id_qualifier == IntPtr.Zero)
				id_qualifier = JNIEnv.GetMethodID (class_ref, "qualifier", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_qualifier), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_annotationType;
#pragma warning disable 0169
		static Delegate GetAnnotationTypeHandler ()
		{
			if (cb_annotationType == null)
				cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
			return cb_annotationType;
		}

		static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Checkerframework.Framework.Qual.IEnsuresQualifier __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Framework.Qual.IEnsuresQualifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
		}
#pragma warning restore 0169

		IntPtr id_annotationType;
		public unsafe global::Java.Lang.Class AnnotationType ()
		{
			if (id_annotationType == IntPtr.Zero)
				id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			global::Org.Checkerframework.Framework.Qual.IEnsuresQualifier __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Framework.Qual.IEnsuresQualifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Checkerframework.Framework.Qual.IEnsuresQualifier __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Framework.Qual.IEnsuresQualifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe global::System.Int32 GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Checkerframework.Framework.Qual.IEnsuresQualifier __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Framework.Qual.IEnsuresQualifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe global::System.String ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
