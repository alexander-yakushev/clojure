/**
 *   Copyright (c) Rich Hickey. All rights reserved.
 *   The use and distribution terms for this software are covered by the
 *   Common Public License 1.0 (http://opensource.org/licenses/cpl.php)
 *   which can be found in the file CPL.TXT at the root of this distribution.
 *   By using this software in any fashion, you are agreeing to be bound by
 * 	 the terms of this license.
 *   You must not remove this notice, or any other, from this software.
 **/

using System;

namespace org.clojure.runtime
{
public class Reflector
    {
public static Object invokeInstanceMember(String name, Object arg1) //throws Exception	{	return throwNotImplemented();	}public static Object invokeInstanceMember(String name, Object arg1, Object arg2) //throws Exception	{	return throwNotImplemented();	}public static Object invokeInstanceMember(String name, Object arg1, Object arg2, Object arg3) //throws Exception	{	return throwNotImplemented();	}public static Object invokeInstanceMember(String name, Object arg1, Object arg2, Object arg3, Object arg4)		//throws Exception	{	return throwNotImplemented();	}public static Object invokeInstanceMember(String name, Object arg1, Object arg2, Object arg3, Object arg4, Object arg5)		//throws Exception	{	return throwNotImplemented();	}public static Object invokeInstanceMember(String name, Object arg1, Object arg2, Object arg3, Object arg4, Object arg5,                                          Cons args)		//throws Exception	{	return throwNotImplemented();	}static protected Object throwNotImplemented()	{	throw new InvalidOperationException("Sorry, not implemented");	}    }
}
